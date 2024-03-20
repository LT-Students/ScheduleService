using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Provider;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data;

public class CategoryRepository : ICategoryRepository
{
  private readonly IDataProvider _provider;

  public CategoryRepository(
    IDataProvider provider)
  {
    _provider = provider;
  }

  public async Task<Guid?> CreateAsync(DbCategory dbCategory)
  {
    _provider.Categories.Add(dbCategory);
    await _provider.SaveAsync();

    return dbCategory.Id;
  }

  public async Task<bool> EditAsync(Guid id, Guid modifiedBy, JsonPatchDocument<DbCategory> request)
  {
    DbCategory dbCategory = await _provider.Categories.FirstOrDefaultAsync(c => c.Id == id);

    if (dbCategory is null || request is null)
    {
      return false;
    }

    request.ApplyTo(dbCategory);
    dbCategory.ModifiedBy = modifiedBy;
    dbCategory.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();
    return true;
  }

  public async Task<(List<DbCategory>, int totalCount)> FindAsync(
    FindCategoriesFilter filter,
    CancellationToken cancellationToken = default)
  {
    IQueryable<DbCategory> dbCategories = _provider.Categories.AsQueryable();

    if (filter.IsActive.HasValue)
    {
      dbCategories = dbCategories.Where(c => c.IsActive == filter.IsActive.Value);
    }

    if (filter.IsAscendingSort.HasValue)
    {
      dbCategories = filter.IsAscendingSort.Value
        ? dbCategories.OrderBy(c => c.Name)
        : dbCategories.OrderByDescending(c => c.Name);
    }

    if (!string.IsNullOrWhiteSpace(filter.NameIncludeSubstring))
    {
      dbCategories = dbCategories.Where(c => c.Name.Contains(filter.NameIncludeSubstring));
    }

    return (
      await dbCategories.Skip(filter.SkipCount).Take(filter.TakeCount).ToListAsync(cancellationToken),
      await dbCategories.CountAsync(cancellationToken));

  }

  public async Task<DbCategory> GetAsync(Guid id, CancellationToken cancellationToken = default)
  {
    return await _provider.Categories.FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
  }

  public async Task<bool> RemoveAsync(DbCategory category, Guid modifiedBy)
  {
    category.IsActive = false;
    category.ModifiedBy = modifiedBy;
    category.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();
    return true;
  }

  public async Task<bool> UpdateAsync(Guid id, Guid modifiedBy, EditCategoryRequest request)
  {
    DbCategory category = await _provider.Categories.FirstOrDefaultAsync(c => c.Id == id);

    if (category is null)
    {
      return false;
    }

    category.Name = request.Name;
    category.Color = request.Color;
    category.IsActive = request.IsActive;
    category.ModifiedBy = modifiedBy;
    category.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();
    return true;
  }

  public async Task<bool> IsNameExistsAsync(string name, Guid workspaceId, Guid? categoryId = null, CancellationToken cancellationToken = default)
  {
    return categoryId.HasValue
      ? await _provider.Categories.AnyAsync(c => c.Name == name && c.WorkspaceId == workspaceId && c.Id != categoryId, cancellationToken)
      : await _provider.Categories.AnyAsync(c => c.Name == name && c.WorkspaceId == workspaceId, cancellationToken);
  }
}

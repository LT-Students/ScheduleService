using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Provider;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data;

public class WorkspaceRepository : IWorkspaceRepository
{
  private readonly IDataProvider _provider;

  public WorkspaceRepository(
    IDataProvider provider)
  {
    _provider = provider;
  }

  public async Task<Guid?> CreateAsync(DbWorkspace workspace)
  {
    _provider.Workspaces.Add(workspace);
    await _provider.SaveAsync();

    return workspace.Id;
  }

  public Task<bool> EditByIdAsync(Guid id, JsonPatchDocument<DbWorkspace> dbWorkspace)
  {
    throw new NotImplementedException();
  }

  public async Task<(List<DbWorkspace>, int totalCount)> FindAsync(FindWorkspaceFilter filter) //add total count?
  {
    IQueryable<DbWorkspace> dbWorkspaces = _provider.Workspaces.AsQueryable();

    if (filter.IsActive.HasValue)
    {
      dbWorkspaces = dbWorkspaces.Where(w => w.IsActive == filter.IsActive);
    }

    if (filter.IsAscendingSort.HasValue)
    {
      dbWorkspaces = filter.IsAscendingSort.Value
        ? dbWorkspaces.OrderBy(w => w.Name)
        : dbWorkspaces.OrderByDescending(w => w.Name);
    }

    if (!string.IsNullOrWhiteSpace(filter.NameIncludeSubstring))
    {
      dbWorkspaces = dbWorkspaces.Where(w => w.Name.Contains(filter.NameIncludeSubstring));
    }

    return (await dbWorkspaces.ToListAsync(), await dbWorkspaces.CountAsync());
  }

  public Task<DbWorkspace> GetAsync(Guid id)
  {
    return _provider.Workspaces.FirstOrDefaultAsync(x => x.Id == id);
  }

  public async Task<bool> RemoveAsync(DbWorkspace dbWorkspace, Guid modifiedBy)
  {
    if (dbWorkspace is null)
    {
      return false;
    }

    dbWorkspace.IsActive = false;
    dbWorkspace.ModifiedBy = modifiedBy;
    dbWorkspace.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();

    return true;
  }

  public async Task<bool> UpdateByIdAsync(Guid id, Guid modifiedBy, EditWorkspaceRequest request)
  {
    DbWorkspace dbWorkspace = await _provider.Workspaces.FirstOrDefaultAsync(w => w.Id == id);

    if (dbWorkspace is null || request is null)
    {
      return false;
    }

    dbWorkspace.Name = request.Name;
    dbWorkspace.ModifiedBy = modifiedBy;
    dbWorkspace.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();

    return true;
  }

  public Task<bool> ExistAsync(Guid id)
  {
    return _provider.Workspaces.AnyAsync(x => x.Id == id && x.IsActive);
  }
}

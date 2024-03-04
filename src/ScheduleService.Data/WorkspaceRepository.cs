using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Provider;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

  public async Task<(List<DbWorkspace>, int totalCount)> FindAsync(
    FindWorkspaceFilter filter,
    CancellationToken cancellationToken = default)
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

    if (!string.IsNullOrWhiteSpace(filter.nameIncludeSubstring))
    {
      dbWorkspaces = dbWorkspaces.Where(w => w.Name.Contains(filter.nameIncludeSubstring));
    }

    return (
      await dbWorkspaces.Skip(filter.SkipCount).Take(filter.TakeCount).ToListAsync(cancellationToken),
      await dbWorkspaces.CountAsync(cancellationToken));
  }

  public async Task<DbWorkspace> GetAsync(Guid id, CancellationToken cancellationToken = default)
  {
    return await _provider.Workspaces.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
  }

  public async Task<bool> RemoveAsync(DbWorkspace dbWorkspace, Guid modifiedBy)
  {
    dbWorkspace.IsActive = false;
    dbWorkspace.ModifiedBy = modifiedBy;
    dbWorkspace.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();

    return true;
  }

  public async Task<bool> EditAsync(Guid id, Guid modifiedBy, JsonPatchDocument<DbWorkspace> request)
  {
    DbWorkspace dbWorkspace = await _provider.Workspaces.FirstOrDefaultAsync(w => w.Id == id);

    if (dbWorkspace is null || request is null)
    {
      return false;
    }

    request.ApplyTo(dbWorkspace);
    dbWorkspace.ModifiedBy = modifiedBy;
    dbWorkspace.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();

    return true;
  }

  public async Task<bool> UpdateAsync(Guid id, Guid modifiedBy, EditWorkspaceRequest request)
  {
    DbWorkspace dbWorkspace = await _provider.Workspaces.FirstOrDefaultAsync(w => w.Id == id);

    if (dbWorkspace is null || request is null)
    {
      return false;
    }

    dbWorkspace.Name = request.Name;
    dbWorkspace.IsActive = request.IsActive;
    dbWorkspace.ModifiedBy = modifiedBy;
    dbWorkspace.ModifiedAtUtc = DateTime.UtcNow;

    await _provider.SaveAsync();

    return true;
  }

  public async Task<bool> IsWorkspaceExistsAsync(Guid id)
  {
    return await _provider.Workspaces.AnyAsync(x => x.Id == id && x.IsActive);
  }

  public async Task<bool> IsNameExistsAsync(string name, Guid? workspaceId = null, CancellationToken cancellationToken = default)
  {
    return workspaceId.HasValue
      ? await  _provider.Workspaces.AnyAsync(d => d.Name == name && d.Id != workspaceId, cancellationToken)
      : await _provider.Workspaces.AnyAsync(d => d.Name == name, cancellationToken);
  }
}

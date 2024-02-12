using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Provider;
using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
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

  public Task<List<DbWorkspace>> GetAllAsync()
  {
    throw new NotImplementedException();
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

  public Task<bool> UpdateByIdAsync(Guid id, DbWorkspace dbWorkspace)
  {
    throw new NotImplementedException();
  }

  public Task<bool> ExistAsync(Guid id)
  {
    return _provider.Workspaces.AnyAsync(x => x.Id == id && x.IsActive);
  }
}

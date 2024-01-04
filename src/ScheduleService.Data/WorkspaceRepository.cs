using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data;

public class WorkspaceRepository : IWorkspaceRepository
{
  public Task CreateAsync(DbWorkspace board)
  {
    throw new NotImplementedException();
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
    throw new NotImplementedException();
  }

  public Task<bool> RemoveAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<bool> UpdateByIdAsync(Guid id, DbWorkspace dbWorkspace)
  {
    throw new NotImplementedException();
  }
}

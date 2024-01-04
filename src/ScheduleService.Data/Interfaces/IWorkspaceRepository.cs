using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.Kernel.Attributes;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces;

[AutoInject]
public interface IWorkspaceRepository
{
  Task CreateAsync(DbWorkspace board);

  Task<List<DbWorkspace>> GetAllAsync();

  Task<DbWorkspace> GetAsync(Guid id);

  Task<bool> EditByIdAsync(Guid id, JsonPatchDocument<DbWorkspace> dbWorkspace);

  Task<bool> UpdateByIdAsync(Guid id, DbWorkspace dbWorkspace);

  Task<bool> RemoveAsync(Guid id);
}

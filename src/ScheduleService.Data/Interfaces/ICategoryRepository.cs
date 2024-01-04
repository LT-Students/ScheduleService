using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.Kernel.Attributes;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces;

[AutoInject]
public interface ICategoryRepository
{
  Task CreateAsync(DbCategory board);

  Task<List<DbCategory>> GetAllAsync();

  Task<DbCategory> GetAsync(Guid id);

  Task<bool> EditByIdAsync(Guid id, JsonPatchDocument<DbCategory> dbCategory);

  Task<bool> UpdateByIdAsync(Guid id, DbCategory dbCategory);

  Task<bool> RemoveAsync(Guid id);
}

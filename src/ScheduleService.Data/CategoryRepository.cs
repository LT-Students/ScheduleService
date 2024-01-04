using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data;

public class CategoryRepository : ICategoryRepository
{
  public Task CreateAsync(DbCategory board)
  {
    throw new NotImplementedException();
  }

  public Task<bool> EditByIdAsync(Guid id, JsonPatchDocument<DbCategory> dbCategory)
  {
    throw new NotImplementedException();
  }

  public Task<List<DbCategory>> GetAllAsync()
  {
    throw new NotImplementedException();
  }

  public Task<DbCategory> GetAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<bool> RemoveAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<bool> UpdateByIdAsync(Guid id, DbCategory dbCategory)
  {
    throw new NotImplementedException();
  }
}

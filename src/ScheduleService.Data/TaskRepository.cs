using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data;

public class TaskRepository : ITaskRepository
{
  public Task<Guid?> CreateAsync()
  {
    throw new NotImplementedException();
  }

  public Task FindAsync()
  {
    throw new NotImplementedException();
  }

  public Task GetAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<bool> EditAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<bool> RemoveAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}

using LT.DigitalOffice.Kernel.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces
{
  [AutoInject]
  public interface ITaskRepository
  {
    Task<Guid?> CreateAsync();

    Task FindAsync();

    Task GetAsync(Guid taskId);

    Task<bool> EditAsync(Guid taskId);

    Task<bool> RemoveAsync(Guid taskId);
  }
}

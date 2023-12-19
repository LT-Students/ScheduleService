using LT.DigitalOffice.Kernel.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces
{
  [AutoInject]
  public interface ITaskRepository
  {
    Task<Guid?> CreateAsync();

    Task FindAsync(GetTasksFilter filter);

    Task GetAsync(Guid taskId);

    Task<bool> EditAsync(Guid taskId, EditTaskRequest request);

    Task<bool> RemoveAsync(Guid taskId);
  }
}

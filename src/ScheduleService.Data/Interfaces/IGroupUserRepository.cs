using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces;

[AutoInject]
public interface IGroupUserRepository
{
  Task<Guid?> CreateAsync(DbTask dbTask);

  Task FindAsync(GetTasksFilter filter);

  Task GetAsync(Guid taskId);

  Task<bool> EditAsync(Guid taskId, EditTaskRequest request);

  Task<bool> RemoveAsync(Guid taskId);
}

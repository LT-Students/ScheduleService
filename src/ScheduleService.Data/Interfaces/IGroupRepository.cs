using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data.Interfaces;

[AutoInject]
public interface IGroupRepository
{
  Task<Guid?> CreateAsync(DbGroup dbGroup);

  Task FindAsync(GetGroupsFilter filter);

  Task GetAsync(Guid groupId);

  Task<bool> EditAsync(Guid groupId, EditGroupRequest request);

  Task<bool> RemoveAsync(Guid groupId);
}

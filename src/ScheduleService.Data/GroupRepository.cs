using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Data;
public class GroupRepository : IGroupRepository
{
  public Task<Guid?> CreateAsync(DbGroup dbGroup)
  {
    throw new NotImplementedException();
  }

  public Task<bool> EditAsync(Guid groupId, EditGroupRequest request)
  {
    throw new NotImplementedException();
  }

  public Task FindAsync(GetGroupsFilter filter)
  {
    throw new NotImplementedException();
  }

  public Task GetAsync(Guid groupId)
  {
    throw new NotImplementedException();
  }

  public Task<bool> RemoveAsync(Guid groupId)
  {
    throw new NotImplementedException();
  }
}

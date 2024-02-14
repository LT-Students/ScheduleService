using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models;

public class GroupInfoMapper : IGroupInfoMapper
{
    public GroupResponse Map(DbGroup dbGroup)
    {
      return dbGroup is null
        ? default
        : new GroupResponse
        {
          Id = dbGroup.Id,
          Name = dbGroup.Name,
          WorkspaceId = dbGroup.WorkspaceId,
        };
    }
}

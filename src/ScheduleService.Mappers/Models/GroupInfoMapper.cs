using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models;

public class GroupInfoMapper : IGroupInfoMapper
{
    public GroupInfo Map(DbGroup dbGroup)
    {
      return dbGroup is null
        ? default
        : new GroupInfo
        {
          Id = dbGroup.Id,
          Name = dbGroup.Name,
          WorkspaceId = dbGroup.WorkspaceId,
        };
    }
}

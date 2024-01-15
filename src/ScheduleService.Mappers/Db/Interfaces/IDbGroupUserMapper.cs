using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;

[AutoInject]
public interface IDbGroupUserMapper
{
  DbGroupsUser Map(CreateGroupUserRequest request);
}

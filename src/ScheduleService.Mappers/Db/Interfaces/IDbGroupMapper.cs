using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;

[AutoInject]
public interface IDbGroupMapper
{
  DbGroup Map(CreateGroupRequest request, Guid userId);
}

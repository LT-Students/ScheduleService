using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;

[AutoInject]
public interface IDbTaskMapper
{
  DbTask Map(CreateTaskRequest request, Guid userId);
}

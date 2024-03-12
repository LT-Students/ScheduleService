using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;

[AutoInject]
public interface IDbWorkspaceMapper
{
  DbWorkspace Map(CreateWorkspaceRequest request, Guid id);
}

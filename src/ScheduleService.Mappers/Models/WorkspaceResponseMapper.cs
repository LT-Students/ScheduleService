using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models;

public class WorkspaceResponseMapper : IWorkspaceResponseMapper
{
  public WorkspaceResponse Map(DbWorkspace dbWorkspace)
  {
    return new WorkspaceResponse
    {
      Id = dbWorkspace.Id,
      Name = dbWorkspace.Name,
      IsActive = dbWorkspace.IsActive
    };
  }
}

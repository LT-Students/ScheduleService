using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;

[AutoInject]
public interface IPatchDbWorkspaceMapper
{
  public JsonPatchDocument<DbWorkspace> Map(JsonPatchDocument<EditWorkspaceRequest> request);
}

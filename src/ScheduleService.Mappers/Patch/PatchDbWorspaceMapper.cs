using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch;

public class PatchDbWorspaceMapper : IPatchDbWorkspaceMapper
{
  public JsonPatchDocument<DbWorkspace> Map(JsonPatchDocument<EditWorkspaceRequest> request)
  {
    JsonPatchDocument<DbWorkspace> result = new();

    foreach (Operation<EditWorkspaceRequest> item in request.Operations)
    {
      result.Operations.Add(new Operation<DbWorkspace>(item.op, item.path, item.from, item.value));
    }

    return result;
  }
}

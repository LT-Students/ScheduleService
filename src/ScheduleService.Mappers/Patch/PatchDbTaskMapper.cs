using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch;

public class PatchDbTaskMapper : IPatchDbTaskMapper
{
  public JsonPatchDocument<DbTask> Map(JsonPatchDocument<EditTaskRequest> request)
  {
    throw new NotImplementedException();
  }
}

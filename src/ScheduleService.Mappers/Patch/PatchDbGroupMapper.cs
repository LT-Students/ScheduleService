using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using Microsoft.AspNetCore.JsonPatch;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch;

public class PatchDbGroupMapper : IPatchDbGroupMapper
{
  public JsonPatchDocument<DbGroup> Map(JsonPatchDocument<EditGroupRequest> request)
  {
    throw new NotImplementedException();
  }
}

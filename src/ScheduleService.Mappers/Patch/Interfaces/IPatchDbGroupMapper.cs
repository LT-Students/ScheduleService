using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;

[AutoInject]
public interface IPatchDbGroupMapper
{
  JsonPatchDocument<DbGroup> Map(JsonPatchDocument<EditGroupRequest> request);
}

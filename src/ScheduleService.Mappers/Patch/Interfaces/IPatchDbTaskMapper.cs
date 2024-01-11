using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;

[AutoInject]
public interface IPatchDbTaskMapper
{
  JsonPatchDocument<DbTask> Map(JsonPatchDocument<EditTaskRequest> request);
}

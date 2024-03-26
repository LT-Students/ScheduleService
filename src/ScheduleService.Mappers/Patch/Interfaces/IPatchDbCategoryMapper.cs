using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;

[AutoInject]
public interface IPatchDbCategoryMapper
{
  JsonPatchDocument<DbCategory> Map(JsonPatchDocument<EditCategoryRequest> request);
}

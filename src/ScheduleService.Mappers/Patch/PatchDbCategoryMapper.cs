using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;

namespace LT.DigitalOffice.ScheduleService.Mappers.Patch;

public class PatchDbCategoryMapper : IPatchDbCategoryMapper
{
  public JsonPatchDocument<DbCategory> Map(JsonPatchDocument<EditCategoryRequest> request)
  {
    JsonPatchDocument<DbCategory> result = new();

    foreach (Operation<EditCategoryRequest> item in request.Operations)
    {
      result.Operations.Add(new Operation<DbCategory>(item.op, item.path, item.from, item.value));
    }

    return result;
  }
}

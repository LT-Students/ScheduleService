using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class EditCategoryCommand : IEditCategoryCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id, JsonPatchDocument<EditCategoryRequest> request)
    {
        throw new NotImplementedException();
    }
}

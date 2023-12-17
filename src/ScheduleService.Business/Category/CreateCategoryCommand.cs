using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class CreateCategoryCommand : ICreateCategoryCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateCategoryRequest request)
    {
        throw new NotImplementedException();
    }
}

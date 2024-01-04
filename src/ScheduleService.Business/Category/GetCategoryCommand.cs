using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoryCommand : IGetCategoryCommand
{
  private readonly ICategoryRepository _repository;

  public GetCategoryCommand(ICategoryRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<CategoryResponse>> ExecuteAsync(Guid id)
    {
      throw new NotImplementedException();
    }
}

using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class UpdatetCategoryCommand : IUpdateCategoryCommand
{
  private readonly ICategoryRepository _repository;

  public UpdatetCategoryCommand(ICategoryRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, UpdateCategoryRequest request)
    {
      throw new NotImplementedException();
    }
}

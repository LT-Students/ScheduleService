using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class RemoveCategoryCommand : IRemoveCategoryCommand
{
  private readonly ICategoryRepository _repository;

  public RemoveCategoryCommand(ICategoryRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}

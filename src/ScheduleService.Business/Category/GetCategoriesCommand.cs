using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoriesCommand : IGetCategoriesCommand
{
  private readonly ICategoryRepository _repository;

  public GetCategoriesCommand(ICategoryRepository repository)
  {
    _repository = repository;
  }

  public Task<FindResultResponse<CategoryInfo>> ExecuteAsync(GetCategoriesFilter request)
  {
    throw new NotImplementedException();
  }
}

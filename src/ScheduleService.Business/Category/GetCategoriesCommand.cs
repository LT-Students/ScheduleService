using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoriesCommand : IGetCategoriesCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public GetCategoriesCommand(
    ICategoryRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _accessValidator = accessValidator;
    _responseCreator = responseCreator;
  }

  public Task<FindResultResponse<CategoryInfo>> ExecuteAsync(GetCategoriesFilter request)
  {
    throw new NotImplementedException();
  }
}

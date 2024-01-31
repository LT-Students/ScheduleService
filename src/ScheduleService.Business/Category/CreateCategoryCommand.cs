using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class CreateCategoryCommand : ICreateCategoryCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly ICreateCategoryRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public CreateCategoryCommand(
    ICategoryRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    ICreateCategoryRequestValidator validator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _accessValidator = accessValidator;
    _responseCreator = responseCreator;
    _validator = validator;
  }

  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateCategoryRequest request)
  {
    throw new NotImplementedException();
  }
}

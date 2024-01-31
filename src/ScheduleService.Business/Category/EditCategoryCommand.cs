using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class EditCategoryCommand : IEditCategoryCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;
  private readonly IEditCategoryRequestValidator _validator;

  public EditCategoryCommand(
    ICategoryRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IEditCategoryRequestValidator validator)
	{
		_httpContextAccessor = httpContextAccessor;
		_repository = repository;
		_accessValidator = accessValidator;
		_responseCreator = responseCreator;
    _validator = validator;
	}

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, JsonPatchDocument<EditCategoryRequest> request)
  {
    throw new NotImplementedException();
  }
}

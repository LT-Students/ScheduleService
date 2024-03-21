using FluentValidation.Results;
using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class EditCategoryCommand : IEditCategoryCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly IPatchDbCategoryMapper _mapper;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;
  private readonly IEditCategoryRequestValidator _validator;

  public EditCategoryCommand(
    ICategoryRepository repository,
    IPatchDbCategoryMapper mapper,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IEditCategoryRequestValidator validator)
	{
		_httpContextAccessor = httpContextAccessor;
		_repository = repository;
    _mapper = mapper;
		_accessValidator = accessValidator;
		_responseCreator = responseCreator;
    _validator = validator;
	}

  public async Task<OperationResultResponse<bool>> ExecuteAsync(
    Guid id,
    JsonPatchDocument<EditCategoryRequest> request,
    CancellationToken ct = default)
  {
    DbCategory dbCategory = await _repository.GetAsync(id, ct);

    if (dbCategory is null)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.NotFound);
    }

    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();

    if (dbCategory.CreatedBy != modifiedBy && !await _accessValidator.IsAdminAsync(modifiedBy))
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.Forbidden);
    }

    ValidationResult validationResult = await _validator.ValidateAsync(((id, dbCategory.WorkspaceId), request));

    if (!validationResult.IsValid)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.BadRequest);
    }

    return new OperationResultResponse<bool>()
    {
      Body = await _repository.EditAsync(id, modifiedBy, _mapper.Map(request), ct)
    };
  }
}

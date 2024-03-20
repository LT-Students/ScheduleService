using FluentValidation.Results;
using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class CreateCategoryCommand : ICreateCategoryCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly IDbCategoryMapper _mapper;
  private readonly ICreateCategoryRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public CreateCategoryCommand(
    ICategoryRepository repository,
    IDbCategoryMapper mapper,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    ICreateCategoryRequestValidator validator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _mapper = mapper;
    _accessValidator = accessValidator;
    _responseCreator = responseCreator;
    _validator = validator;
  }

  public async Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateCategoryRequest request)
  {
    ValidationResult validationResult = await _validator.ValidateAsync(request);

    if (!validationResult.IsValid)
    {
      return _responseCreator.CreateFailureResponse<Guid?>(
        HttpStatusCode.BadRequest,
        validationResult.Errors.ConvertAll(v => v.ErrorMessage));
    }

    Guid createdBy = _httpContextAccessor.HttpContext.GetUserId();

    OperationResultResponse<Guid?> response = new()
    {
      Body = await _repository.CreateAsync(_mapper.Map(request, createdBy))
    };

    if (response.Body is null)
    {
      return _responseCreator.CreateFailureResponse<Guid?>(HttpStatusCode.BadRequest);
    }

    _httpContextAccessor.HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;

    return response;
  }
}

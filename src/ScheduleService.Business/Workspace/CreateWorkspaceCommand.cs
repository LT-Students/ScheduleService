using FluentValidation.Results;
using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class CreateWorkspaceCommand : ICreateWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly ICreateWorkspaceRequestValidator _validator;
  private readonly IDbWorkspaceMapper _mapper;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public CreateWorkspaceCommand(
    IWorkspaceRepository repository,
    IAccessValidator accessValidator,
    IDbWorkspaceMapper mapper,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    ICreateWorkspaceRequestValidator validator)
  {
    _repository = repository;
    _accessValidator = accessValidator;
    _mapper = mapper;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _validator = validator;
  }

  public async Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateWorkspaceRequest request)
  {
    ValidationResult validationResult = await _validator.ValidateAsync(request);

    if (!validationResult.IsValid)
    {
      return _responseCreator.CreateFailureResponse<Guid?>(
        HttpStatusCode.BadRequest,
        validationResult.Errors.Select(v => v.ErrorMessage).ToList());
    }

    OperationResultResponse<Guid?> response = new();
    Guid createdBy = _httpContextAccessor.HttpContext.GetUserId();

    response.Body = await _repository.CreateAsync(_mapper.Map(request, createdBy));

    if (response.Body is null)
    {
      response = _responseCreator.CreateFailureResponse<Guid?>(HttpStatusCode.BadRequest);
      return response;
    }

    _httpContextAccessor.HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;

    return response;
  }
}

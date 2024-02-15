using FluentValidation.Results;
using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class UpdateWorkspaceCommand : IUpdateWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IEditWorkspaceRequestValidator _validator;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public UpdateWorkspaceCommand(
    IWorkspaceRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IEditWorkspaceRequestValidator validator)
  {
    _repository = repository;
    _accessValidator = accessValidator;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _validator = validator;
  }

  public async Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, EditWorkspaceRequest request)
  {
    //ValidationResult validationResult = await _validator.ValidateAsync((id, request));
    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();

    //if (!validationResult.IsValid)
    //{
    //  return _responseCreator.CreateFailureResponse<bool>(System.Net.HttpStatusCode.BadRequest,
    //    validationResult.Errors.Select(x => x.ErrorMessage).ToList());
    //}

    //check rights?

    return new()
    {
      Body = await _repository.UpdateAsync(id, modifiedBy, request)
      //errors?
    };
  }
}

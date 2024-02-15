using FluentValidation.Results;
using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class EditWorkspaceCommand : IEditWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IEditWorkspaceRequestValidator _validator;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IPatchDbWorkspaceMapper _mapper;
  private readonly IAccessValidator _accessValidator;

  public EditWorkspaceCommand(
    IWorkspaceRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IPatchDbWorkspaceMapper mapper,
    IEditWorkspaceRequestValidator validator)
  {
    _repository = repository;
    _accessValidator = accessValidator;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _mapper = mapper;
    _validator = validator;
  }

  public async Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, JsonPatchDocument<EditWorkspaceRequest> request)
  {
    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();
    DbWorkspace dbWorkspace = await _repository.GetAsync(id);

    if (!(modifiedBy == dbWorkspace.CreatedBy))
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.Forbidden);
    }

    ValidationResult validationResult = await _validator.ValidateAsync((id, request));

    if (!validationResult.IsValid)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.BadRequest,
        validationResult.Errors.Select(v => v.ErrorMessage).ToList());
    }

    OperationResultResponse<bool> response = new()
    {
      Body = await _repository.EditAsync(id, _mapper.Map(request))
    };

    return response;
  }
}

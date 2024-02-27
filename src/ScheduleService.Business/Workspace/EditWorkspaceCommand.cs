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
  private readonly IAccessValidator _accessValidator;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IPatchDbWorkspaceMapper _mapper;

  public EditWorkspaceCommand(
    IWorkspaceRepository repository,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IPatchDbWorkspaceMapper mapper,
    IEditWorkspaceRequestValidator validator,
    IAccessValidator accessValidator)
  {
    _repository = repository;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _mapper = mapper;
    _validator = validator;
    _accessValidator = accessValidator;
  }

  public async Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, JsonPatchDocument<EditWorkspaceRequest> request)
  {
    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();
    DbWorkspace dbWorkspace = await _repository.GetAsync(id);
    bool isAdmin = await _accessValidator.IsAdminAsync(modifiedBy);

    if (modifiedBy != dbWorkspace.CreatedBy && !isAdmin)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.Forbidden);
    }

    ValidationResult validationResult = await _validator.ValidateAsync((id, request));

    if (!validationResult.IsValid)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.BadRequest,
        validationResult.Errors.Select(v => v.ErrorMessage).ToList());
    }

    return new OperationResultResponse<bool>()
    {
      Body = await _repository.EditAsync(id, modifiedBy, _mapper.Map(request))
    };
  }
}

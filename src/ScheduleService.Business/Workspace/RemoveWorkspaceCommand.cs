using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class RemoveWorkspaceCommand : IRemoveWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public RemoveWorkspaceCommand(
    IWorkspaceRepository repository,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator)
  {
    _repository = repository;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
  }

  public async Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    DbWorkspace dbWorkspace = await _repository.GetAsync(id);

    if (dbWorkspace is null)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.NotFound);
    }

    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();

    if (modifiedBy != dbWorkspace.CreatedBy && !await _accessValidator.IsAdminAsync(modifiedBy))
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.Forbidden);
    }

    return new OperationResultResponse<bool>
    {
      Body = await _repository.RemoveAsync(dbWorkspace, modifiedBy)
    };
  }
}

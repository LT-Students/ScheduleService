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

  public RemoveWorkspaceCommand(
    IWorkspaceRepository repository,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
  }

  public async Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    DbWorkspace dbWorkspace = await _repository.GetAsync(id);
    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();

    if (!(modifiedBy == dbWorkspace.CreatedBy))
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.Forbidden);
    }

    if (dbWorkspace is null)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.NotFound);
    }

    OperationResultResponse<bool> response = new()
    {
      Body = await _repository.RemoveAsync(dbWorkspace, modifiedBy)
    };

    return response;
  }
}

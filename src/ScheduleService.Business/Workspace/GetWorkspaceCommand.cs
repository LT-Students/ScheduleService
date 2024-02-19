using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class GetWorkspaceCommand : IGetWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IWorkspaceResponseMapper _mapper;

  public GetWorkspaceCommand(
    IWorkspaceRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IWorkspaceResponseMapper mapper)
  {
    _repository = repository;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _mapper = mapper;
  }

  public async Task<OperationResultResponse<WorkspaceResponse>> ExecuteAsync(Guid id)
  {
    DbWorkspace dbWorkspace = await _repository.GetAsync(id);

    if (dbWorkspace is null)
    {
      return _responseCreator.CreateFailureResponse<WorkspaceResponse>(HttpStatusCode.NotFound);
    }

    WorkspaceResponse response = _mapper.Map(dbWorkspace);

    return new OperationResultResponse<WorkspaceResponse>(response);
  }
}

using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using LT.DigitalOffice.ScheduleService.Models.Db;
using System.Linq;
using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class FindWorkspacesCommand : IFindWorkspacesCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IWorkspaceResponseMapper _responseMapper;
  private readonly IHttpContextAccessor _httpContextAccessor;

  public FindWorkspacesCommand(
    IWorkspaceRepository repository,
    IWorkspaceResponseMapper responseMapper,
    IHttpContextAccessor httpContextAccessor)
  {
    _repository = repository;
    _responseMapper = responseMapper;
    _httpContextAccessor = httpContextAccessor;
  }

  public async Task<FindResultResponse<WorkspaceResponse>> ExecuteAsync(FindWorkspaceFilter filter)
  {
    (List<DbWorkspace> dbWorkspaces, int totalCount) = await _repository.FindAsync(filter);

    if (dbWorkspaces is null || dbWorkspaces.Count() == 0)
    {
      return new FindResultResponse<WorkspaceResponse>();
    }

    return new FindResultResponse<WorkspaceResponse>
    {
      Body = dbWorkspaces.ConvertAll(dbWorkspace => _responseMapper.Map(dbWorkspace)).ToList(),
      TotalCount = totalCount
    };
  }
}

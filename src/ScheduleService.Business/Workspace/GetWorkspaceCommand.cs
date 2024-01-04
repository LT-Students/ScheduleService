using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class GetWorkspaceCommand : IGetWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;

  public GetWorkspaceCommand(IWorkspaceRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<WorkspaceResponse>> ExecuteAsync(Guid id)
    {
      throw new NotImplementedException();
    }
}

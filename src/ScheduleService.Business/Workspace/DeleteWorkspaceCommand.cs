using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class DeleteWorkspaceCommand : IDeleteWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;

  public DeleteWorkspaceCommand(IWorkspaceRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
    {
      throw new NotImplementedException();
    }
}

using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class CreateWorkspaceCommand : ICreateWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;

  public CreateWorkspaceCommand(IWorkspaceRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateWorkspaceRequest request)
    {
      throw new NotImplementedException();
    }
}

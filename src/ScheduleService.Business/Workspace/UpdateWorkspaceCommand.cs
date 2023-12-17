using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class UpdateWorkspaceCommand : IUpdateWorkspaceCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id, UpdateWorkspaceRequest request)
    {
        throw new NotImplementedException();
    }
}

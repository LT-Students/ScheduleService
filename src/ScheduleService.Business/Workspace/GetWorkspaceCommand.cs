using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class GetWorkspaceCommand : IGetWorkspaceCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}

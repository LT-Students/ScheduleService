using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class EditWorkspaceCommand : IEditWorkspaceCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id, JsonPatchDocument<EditWorkspaceRequest> request)
    {
        throw new NotImplementedException();
    }
}

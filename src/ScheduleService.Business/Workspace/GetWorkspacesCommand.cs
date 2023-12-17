using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class GetWorkspacesCommand : IGetWorkspacesCommand
{
    public Task<FindResultResponse<WorkspaceInfo>> ExecuteAsync(GetWorkspacesFilter request)
    {
        throw new System.NotImplementedException();
    }
}

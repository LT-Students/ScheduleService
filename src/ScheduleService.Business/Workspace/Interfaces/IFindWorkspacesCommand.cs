using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;

[AutoInject]
public interface IFindWorkspacesCommand
{
  Task<FindResultResponse<WorkspaceResponse>> ExecuteAsync(FindWorkspaceFilter request);
}

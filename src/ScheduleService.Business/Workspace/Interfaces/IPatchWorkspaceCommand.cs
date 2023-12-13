using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces
{
  [AutoInject]
  public interface IPatchWorkspaceCommand
  {
    Task<IActionResult> ExecuteAsync(PatchWorkspaceRequest request);
    }
}

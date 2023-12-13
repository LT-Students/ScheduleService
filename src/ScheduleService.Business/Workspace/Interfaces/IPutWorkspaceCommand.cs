using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces
{
  [AutoInject]
  public interface IPutWorkspaceCommand
  {
    Task<IActionResult> ExecuteAsync(PutWorkspaceRequest request);
    }
}

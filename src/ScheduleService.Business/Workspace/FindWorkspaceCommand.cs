using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace
{
  public class FindWorkspaceCommand : IFindWorkspaceCommand
  {
    public Task<IActionResult> ExecuteAsync(FindWorkspacesFilter request)
    {
      throw new System.NotImplementedException();
    }
  }
}

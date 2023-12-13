using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace
{
  public class PutWorkspaceCommand : IPutWorkspaceCommand
  {
    public Task<IActionResult> ExecuteAsync(PutWorkspaceRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

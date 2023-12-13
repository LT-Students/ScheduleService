using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace
{
  public class GetWorkspaceCommand : IGetWorkspaceCommand
  {
    public Task<IActionResult> ExecuteAsync(GetWorkspaceRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

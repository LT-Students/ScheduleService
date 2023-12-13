using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace
{
  public class DeleteWorkspaceCommand : IDeleteWorkspaceCommand
  {
    public Task<IActionResult> ExecuteAsync(DeleteWorkspaceRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

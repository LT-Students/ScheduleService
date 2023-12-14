using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class GetWorkspaceCommand : IGetWorkspaceCommand
{
  public Task<IActionResult> ExecuteAsync(Guid id)
  {
    throw new System.NotImplementedException();
  }
}

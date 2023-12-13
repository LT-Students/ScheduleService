﻿using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces
{
  [AutoInject]
  public interface IFindWorkspaceCommand
  {
    Task<IActionResult> ExecuteAsync(FindWorkspacesFilter request);
    }
}

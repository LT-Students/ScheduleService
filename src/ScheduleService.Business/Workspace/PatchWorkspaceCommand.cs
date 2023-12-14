﻿using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class PatchWorkspaceCommand : IPatchWorkspaceCommand
{
  public Task<IActionResult> ExecuteAsync(Guid id, PatchWorkspaceRequest request)
  {
    throw new System.NotImplementedException();
  }
}

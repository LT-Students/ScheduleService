﻿using LT.DigitalOffice.Kernel.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;

[AutoInject]
public interface IGetWorkspaceCommand
{
  Task<IActionResult> ExecuteAsync(Guid id);
}

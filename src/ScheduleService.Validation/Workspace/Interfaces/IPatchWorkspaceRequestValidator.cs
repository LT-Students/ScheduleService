﻿using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces
{
  [AutoInject]
  internal interface IPatchWorkspaceRequestValidator : IValidator<PatchWorkspaceRequest>
  {
  }
}

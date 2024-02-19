using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;

[AutoInject]
public interface IUpdateWorkspaceRequestValidator : IValidator<EditWorkspaceRequest>
{
}

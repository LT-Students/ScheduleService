using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;
using System.Threading;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;

[AutoInject]
public interface IUpdateWorkspaceRequestValidator : IValidator<(Guid, EditWorkspaceRequest)>
{
}

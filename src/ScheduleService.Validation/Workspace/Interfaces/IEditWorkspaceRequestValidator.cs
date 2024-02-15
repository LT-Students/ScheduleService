using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using Microsoft.AspNetCore.JsonPatch;
using System;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;

[AutoInject]
public interface IEditWorkspaceRequestValidator : IValidator<(Guid, JsonPatchDocument<EditWorkspaceRequest>)>
{
}

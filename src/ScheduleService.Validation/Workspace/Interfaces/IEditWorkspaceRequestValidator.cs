using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;

public interface IEditWorkspaceRequestValidator : IValidator<EditWorkspaceRequest>
{
}

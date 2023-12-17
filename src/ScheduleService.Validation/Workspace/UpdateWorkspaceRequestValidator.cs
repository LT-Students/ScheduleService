using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace;
public class UpdateWorkspaceRequestValidator : AbstractValidator<UpdateWorkspaceRequest>, IUpdateWorkspaceRequestValidator
{
}

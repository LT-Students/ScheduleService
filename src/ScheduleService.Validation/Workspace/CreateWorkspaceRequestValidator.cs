using FluentValidation;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Resources;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace;

public class CreateWorkspaceRequestValidator : AbstractValidator<CreateWorkspaceRequest>, ICreateWorkspaceRequestValidator
{
  public CreateWorkspaceRequestValidator(
    IWorkspaceRepository repository)
  {
    RuleFor(request => request.Name)
      .NotEmpty()
      .MaximumLength(100).WithMessage(WorkspaceRequestValidatorResource.NameTooLong)
      .MustAsync(async (request, cancellationToken) => !await repository.IsNameExistsAsync(name: request, cancellationToken : cancellationToken))
      .WithMessage(WorkspaceRequestValidatorResource.ExistingName);
  }
}

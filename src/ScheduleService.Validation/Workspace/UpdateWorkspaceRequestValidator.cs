using FluentValidation;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace;

public class UpdateWorkspaceRequestValidator : AbstractValidator<EditWorkspaceRequest>, IUpdateWorkspaceRequestValidator
{
  public UpdateWorkspaceRequestValidator(
    IWorkspaceRepository repository)
  {
    RuleFor(request => request.Name)
      .NotEmpty()
      .MaximumLength(100).WithMessage("Name too long");
      //.MustAsync(async (request, _) => !await repository.NameExistAsync(request)).WithMessage("Name already exist");
  }
}

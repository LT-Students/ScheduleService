using FluentValidation;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using System;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace;

public class UpdateWorkspaceRequestValidator : AbstractValidator<(Guid, EditWorkspaceRequest)>, IUpdateWorkspaceRequestValidator
{
  public UpdateWorkspaceRequestValidator(
    IWorkspaceRepository repository)
  {
    RuleFor(request => request.Item2.Name)
      .NotEmpty()
      .MaximumLength(100).WithMessage("Name too long.");

    RuleFor(tuple => tuple)
      .MustAsync(async (tuple, _) => !await repository.IsNameExists(tuple.Item2.Name, tuple.Item1)).WithMessage("Name already exist.");
  }
}

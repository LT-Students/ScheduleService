using FluentValidation;
using FluentValidation.Results;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using System.Threading;
using System.Threading.Tasks;

public class PatchWorkspaceRequestValidator : AbstractValidator<PatchWorkspaceRequestValidator>, IPatchWorkspaceRequestValidator
{
  public ValidationResult Validate(PatchWorkspaceRequest instance)
  {
    throw new System.NotImplementedException();
  }

  public Task<ValidationResult> ValidateAsync(PatchWorkspaceRequest instance, CancellationToken cancellation = default)
  {
    throw new System.NotImplementedException();
  }
}

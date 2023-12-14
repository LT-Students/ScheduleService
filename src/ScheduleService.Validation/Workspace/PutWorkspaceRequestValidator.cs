using FluentValidation;
using FluentValidation.Results;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace;
public class PutWorkspaceRequestValidator : AbstractValidator<PutWorkspaceRequestValidator>, IPutWorkspaceRequestValidator
{
  public ValidationResult Validate(PutWorkspaceRequest instance)
  {
    throw new System.NotImplementedException();
  }

  public Task<ValidationResult> ValidateAsync(PutWorkspaceRequest instance, CancellationToken cancellation = default)
  {
    throw new System.NotImplementedException();
  }
}

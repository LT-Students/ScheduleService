using FluentValidation;
using FluentValidation.Results;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using System.Threading;
using System.Threading.Tasks;

public class CreateWorkspaceRequestValidator : AbstractValidator<CreateWorkspaceRequestValidator>, ICreateWorkspaceRequestValidator
{
  public ValidationResult Validate(CreateWorkspaceRequest instance)
  {
    throw new System.NotImplementedException();
  }

  public Task<ValidationResult> ValidateAsync(CreateWorkspaceRequest instance, CancellationToken cancellation = default)
  {
    throw new System.NotImplementedException();
  }
}

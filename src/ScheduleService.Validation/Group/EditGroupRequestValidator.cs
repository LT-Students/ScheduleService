using FluentValidation;
using FluentValidation.Results;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Validation.Group;

public class EditGroupRequestValidator : AbstractValidator<JsonPatchDocument<EditGroupRequest>>, IEditGroupRequestValidator
{
  public EditGroupRequestValidator() { }

  public ValidationResult Validate(EditGroupRequest instance)
  {
    throw new System.NotImplementedException();
  }

  public Task<ValidationResult> ValidateAsync(EditGroupRequest instance, CancellationToken cancellation = default)
  {
    throw new System.NotImplementedException();
  }
}

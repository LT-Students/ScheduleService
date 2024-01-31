using FluentValidation;
using FluentValidation.Results;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Validation.Group;

public class UpdateGroupRequestValidator : AbstractValidator<EditGroupRequest>, IUpdateGroupRequestValidator
{
  public UpdateGroupRequestValidator() { }

  public ValidationResult Validate(JsonPatchDocument<EditGroupRequest> instance)
  {
    throw new System.NotImplementedException();
  }

  public Task<ValidationResult> ValidateAsync(JsonPatchDocument<EditGroupRequest> instance, CancellationToken cancellation = default)
  {
    throw new System.NotImplementedException();
  }
}

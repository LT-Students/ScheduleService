using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Validation.Group;

public class UpdateGroupRequestValidator : AbstractValidator<JsonPatchDocument<EditGroupRequest>>, IUpdateGroupRequestValidator
{
  public UpdateGroupRequestValidator() { }
}

using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Group;

public class UpdateGroupRequestValidator : AbstractValidator<UpdateGroupRequest>, IUpdateGroupRequestValidator
{
  public UpdateGroupRequestValidator() { }
}

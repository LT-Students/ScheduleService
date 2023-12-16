using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Groups;

public class EditGroupRequestValidator : AbstractValidator<EditGroupRequest>, IEditGroupRequestValidator
{
  public EditGroupRequestValidator() { }
}

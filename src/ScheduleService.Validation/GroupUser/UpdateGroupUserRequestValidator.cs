using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Validation.GroupUser.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.GroupUser;

public class UpdateGroupUserRequestValidator : AbstractValidator<UpdateGroupUserRequest>, IUpdateGroupUserRequestValidator
{
  public UpdateGroupUserRequestValidator()
  {
  }
}

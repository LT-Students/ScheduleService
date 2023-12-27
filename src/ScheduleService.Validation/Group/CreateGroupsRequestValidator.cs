using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Group;

public class CreateGroupsRequestValidator : AbstractValidator<CreateGroupRequest>, ICreateGroupRequestValidator
{
  public CreateGroupsRequestValidator() { }
}

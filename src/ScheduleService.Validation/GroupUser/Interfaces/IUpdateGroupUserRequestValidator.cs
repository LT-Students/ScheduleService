using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;

namespace LT.DigitalOffice.ScheduleService.Validation.GroupUser.Interfaces;

public interface IUpdateGroupUserRequestValidator : IValidator<UpdateGroupUserRequest>
{
}

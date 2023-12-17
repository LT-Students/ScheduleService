using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;

namespace LT.DigitalOffice.ScheduleService.Validation.GroupUser.Interfaces;

[AutoInject]
public interface ICreateGroupUserRequestValidator : IValidator<CreateGroupUserRequest>
{
}

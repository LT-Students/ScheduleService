using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;

namespace LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;

public interface IUpdateGroupRequestValidator : IValidator<UpdateGroupRequest>
{
}

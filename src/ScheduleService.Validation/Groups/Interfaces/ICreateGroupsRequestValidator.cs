using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Groups;

namespace LT.DigitalOffice.ScheduleService.Validation.Groups.Interfaces;

[AutoInject]
public interface ICreateGroupsRequestValidator : IValidator<CreateGroupsRequest>
{
}

using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;

[AutoInject]
public interface IUpdateGroupRequestValidator : IValidator<JsonPatchDocument<EditGroupRequest>>
{
}

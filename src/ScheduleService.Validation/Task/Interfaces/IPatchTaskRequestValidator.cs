using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;

namespace LT.DigitalOffice.ScheduleService.Validation.Task.Interfaces;

[AutoInject]
public interface IPatchTaskRequestValidator : IValidator<EditTaskRequest>
{
}


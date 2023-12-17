using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Validation.Task.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Task
{
  public class CreateTaskValidator : AbstractValidator<CreateTaskRequest>, ICreateTaskRequestValidator
  {
  }
}


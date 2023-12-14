using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;

namespace LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;

public interface ICreateCategoryRequestValidator : IValidator<CreateCategoryRequest>
{
}

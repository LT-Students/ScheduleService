using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Category;

public class UpdateCategoryRequestValidator : AbstractValidator<UpdateCategoryRequest>, IUpdateCategoryRequestValidator
{
}

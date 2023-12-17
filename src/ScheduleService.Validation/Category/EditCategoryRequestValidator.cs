using FluentValidation;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;

namespace LT.DigitalOffice.ScheduleService.Validation.Category;
public class EditCategoryRequestValidator : AbstractValidator<EditCategoryRequest>, IEditCategoryRequestValidator
{
}

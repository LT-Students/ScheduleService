using FluentValidation;
using FluentValidation.Results;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Validation.Category;
public class PutCategoryRequestValidator : AbstractValidator<PutCategoryRequestValidator>, IPutCategoryRequestValidator
{
  public ValidationResult Validate(PutCategoryRequest instance)
  {
    throw new System.NotImplementedException();
  }

  public Task<ValidationResult> ValidateAsync(PutCategoryRequest instance, CancellationToken cancellation = default)
  {
    throw new System.NotImplementedException();
  }
}

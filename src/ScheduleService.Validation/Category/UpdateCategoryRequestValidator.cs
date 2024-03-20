using FluentValidation;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using System;

namespace LT.DigitalOffice.ScheduleService.Validation.Category;

public  class UpdateCategoryRequestValidator : AbstractValidator<(Guid, Guid, EditCategoryRequest)>, IUpdateCategoryRequestValidator
{
  public UpdateCategoryRequestValidator(
    ICategoryRepository repository)
  {
    RuleFor(request => request.Item3.Name)
      .NotEmpty()
      .MaximumLength(20).WithMessage("Name is too long.");

    RuleFor(request => request)
      .MustAsync(async (request, cancellationToken) => !await repository.IsNameExistsAsync(name: request.Item3.Name,
      workspaceId: request.Item1, categoryId: request.Item2, cancellationToken: cancellationToken))
      .WithMessage("Name already exist.");
  }
}

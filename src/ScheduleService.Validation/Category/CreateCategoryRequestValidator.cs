using FluentValidation;
using LT.DigitalOffice.ScheduleService.Data;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Validation.Category.Resources;

namespace LT.DigitalOffice.ScheduleService.Validation.Category;

public class CreateCategoryRequestValidator : AbstractValidator<CreateCategoryRequest>, ICreateCategoryRequestValidator
{
  public CreateCategoryRequestValidator(
    ICategoryRepository categoryRepository,
    IWorkspaceRepository workspaceRepository)
  {
    RuleFor(request => request.WorkspaceId)
      .MustAsync(workspaceRepository.IsWorkspaceExistsAsync)
      .WithMessage(CategoryRequestValidatorResource.WorkspaceDoesNotExist);

    RuleFor(request => request.Name)
      .NotEmpty()
      .MaximumLength(20).WithMessage(CategoryRequestValidatorResource.NameTooLong);

    RuleFor(request => request)
      .MustAsync(async (request, cancellationToken) => !await categoryRepository.IsNameExistsAsync(name: request.Name,
      workspaceId: request.WorkspaceId, cancellationToken: cancellationToken))
      .WithMessage(CategoryRequestValidatorResource.ExistingName);
  }
}

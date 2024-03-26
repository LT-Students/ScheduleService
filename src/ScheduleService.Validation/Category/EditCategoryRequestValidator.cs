using FluentValidation;
using LT.DigitalOffice.Kernel.Validators;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Enums;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Validation.Category.Resources;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.ScheduleService.Validation.Category;

public class EditCategoryRequestValidator : ExtendedEditRequestValidator<(Guid, Guid), EditCategoryRequest>, IEditCategoryRequestValidator
{
  private readonly ICategoryRepository _categoryRepository;

  private async System.Threading.Tasks.Task HandleInternalPropertyValidationAsync(
    Operation<EditCategoryRequest> requestedOperation,
    Guid workspaceId,
    Guid categoryId,
    ValidationContext<((Guid, Guid), JsonPatchDocument<EditCategoryRequest>)> context)
  {
    RequestedOperation = requestedOperation;
    Context = context;

    #region Paths

    AddCorrectPaths(
      new List<string>
      {
          nameof(EditCategoryRequest.Name),
          nameof(EditCategoryRequest.Color),
          nameof(EditCategoryRequest.IsActive)
      });

    AddCorrectOperations(nameof(EditCategoryRequest.Name), new() { OperationType.Replace });
    AddCorrectOperations(nameof(EditCategoryRequest.Color), new() { OperationType.Replace });
    AddCorrectOperations(nameof(EditCategoryRequest.IsActive), new() { OperationType.Replace });

    #endregion

    #region Name

    AddFailureForPropertyIfNot(
      nameof(EditCategoryRequest.Name),
      x => x == OperationType.Replace,
      new()
      {
        {x  => !string.IsNullOrEmpty(x.value?.ToString().Trim()), CategoryRequestValidatorResource.EmptyName},
        {x => x.value?.ToString().Length < 21, CategoryRequestValidatorResource.NameTooLong},
      }, CascadeMode.Stop);

    await AddFailureForPropertyIfNotAsync(
      nameof(EditCategoryRequest.Name),
      x => x == OperationType.Replace,
      new()
      {
        {
          async x =>
            !await _categoryRepository.IsNameExistsAsync(x.value?.ToString(), workspaceId, categoryId),
            CategoryRequestValidatorResource.ExistingName
        }
      });

    #endregion

    #region Color

    AddFailureForPropertyIfNot(
          nameof(EditCategoryRequest.Color),
          x => x == OperationType.Replace,
          new()
          {
            {x => Enum.TryParse(x.value?.ToString(), out CategoryColor _), CategoryRequestValidatorResource.IncorrectColor}
          });

    #endregion

    #region IsActive

    AddFailureForPropertyIfNot(
      nameof(EditCategoryRequest.IsActive),
      x => x == OperationType.Replace,
      new()
      {
        {x => bool.TryParse(x.value?.ToString(), out bool _), CategoryRequestValidatorResource.IncorrectIsActiveFormat}
      });

    #endregion

  }

  public EditCategoryRequestValidator(
    ICategoryRepository repository)
  {
    _categoryRepository = repository;

    RuleFor(x => x)
      .CustomAsync(async (x, context, _) =>
      {
        foreach (var op in x.Item2.Operations)
        {
          await HandleInternalPropertyValidationAsync(op, x.Item1.Item1, x.Item1.Item2, context);
        }
      });
  }
}

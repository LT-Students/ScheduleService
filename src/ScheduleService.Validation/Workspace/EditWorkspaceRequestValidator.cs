using FluentValidation;
using LT.DigitalOffice.Kernel.Validators;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Resources;

namespace LT.DigitalOffice.ScheduleService.Validation.Workspace;

public class EditWorkspaceRequestValidator : ExtendedEditRequestValidator<Guid, EditWorkspaceRequest>, IEditWorkspaceRequestValidator
{
  private readonly IWorkspaceRepository _workspaceRepository;

  private async System.Threading.Tasks.Task HandleInternalPropertyValidationAsync(
    Operation<EditWorkspaceRequest> requestedOperation,
    Guid workspaceId,
    ValidationContext<(Guid, JsonPatchDocument<EditWorkspaceRequest>)> context)
  {
    RequestedOperation = requestedOperation;
    Context = context;

    #region Paths

    AddCorrectPaths(
      new List<string>
      {
          nameof(EditWorkspaceRequest.Name),
          nameof(EditWorkspaceRequest.IsActive)
      });

    AddCorrectOperations(nameof(EditWorkspaceRequest.Name), new() { OperationType.Replace });
    AddCorrectOperations(nameof(EditWorkspaceRequest.IsActive), new() { OperationType.Replace });

    #endregion

    #region Name

    AddFailureForPropertyIfNot(
      nameof(EditWorkspaceRequest.Name),
      x => x == OperationType.Replace,
      new()
      {
        {x  => !string.IsNullOrEmpty(x.value?.ToString().Trim()), WorkspaceRequestValidatorResource.EmptyName},
        {x => x.value?.ToString().Length < 101,WorkspaceRequestValidatorResource.NameTooLong },
      }, CascadeMode.Stop);

    await AddFailureForPropertyIfNotAsync(
      nameof(EditWorkspaceRequest.Name),
      x => x == OperationType.Replace,
      new()
      {
        {
          async x =>
            !await _workspaceRepository.IsNameExistsAsync(x.value?.ToString(), workspaceId),
            WorkspaceRequestValidatorResource.ExistingName
        }
      });

    #endregion

    #region IsActive

    AddFailureForPropertyIfNot(
      nameof(EditWorkspaceRequest.IsActive),
      x => x == OperationType.Replace,
      new()
      {
        {x => bool.TryParse(x.value?.ToString(), out bool _), WorkspaceRequestValidatorResource.IncorrectIsActiveFormat}
      });

    #endregion
  }

  public EditWorkspaceRequestValidator(
    IWorkspaceRepository repository)
  {
    _workspaceRepository = repository;

    RuleFor(x => x)
      .CustomAsync(async (x, context, cancellationToken) =>
      {
        foreach (var op in x.Item2.Operations)
        {
          await HandleInternalPropertyValidationAsync(op, x.Item1, context);
        }
      });
  }
}

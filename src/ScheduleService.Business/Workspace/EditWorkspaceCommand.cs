﻿using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Validation.Workspace.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class EditWorkspaceCommand : IEditWorkspaceCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IEditWorkspaceRequestValidator _validator;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public EditWorkspaceCommand(
    IWorkspaceRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator,
    IEditWorkspaceRequestValidator validator)
  {
    _repository = repository;
    _accessValidator = accessValidator;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
    _validator = validator;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, JsonPatchDocument<EditWorkspaceRequest> request)
  {
    throw new NotImplementedException();
  }
}
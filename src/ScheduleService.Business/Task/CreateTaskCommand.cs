﻿using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Validation.Task.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class CreateTaskCommand : ICreateTaskCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ITaskRepository _repository;
  private readonly ICreateTaskRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;
  private readonly IDbTaskMapper _dbTaskMapper;

  public CreateTaskCommand(
    IHttpContextAccessor httpContextAccessor,
    ITaskRepository repository,
    ICreateTaskRequestValidator validator,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator,
    IDbTaskMapper dbTaskMapper)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
    _dbTaskMapper = dbTaskMapper;
  }

  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateTaskRequest request)
  {
    throw new NotImplementedException();
  }
}

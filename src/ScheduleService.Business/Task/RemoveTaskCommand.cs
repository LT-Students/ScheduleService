using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class RemoveTaskCommand : IRemoveTaskCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ITaskRepository _repository;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public RemoveTaskCommand(
    IHttpContextAccessor httpContextAccessor,
    ITaskRepository repository,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}


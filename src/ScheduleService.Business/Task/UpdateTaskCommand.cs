using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Validation.Task.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class UpdateTaskCommand : IUpdateTaskCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ITaskRepository _repository;
  private readonly IEditTaskRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public UpdateTaskCommand(
   IHttpContextAccessor httpContextAccessor,
   ITaskRepository repository,
   IEditTaskRequestValidator validator,
   IResponseCreator responseCreator,
   IAccessValidator accessValidator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(EditTaskRequest request, Guid id)
  {
    throw new NotImplementedException();
  }
}

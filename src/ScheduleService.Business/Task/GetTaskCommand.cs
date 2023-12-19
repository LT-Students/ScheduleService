using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class GetTaskCommand : IGetTaskCommand
{
  private readonly ITaskRepository _repository;
  private readonly IResponseCreator _responseCreator;

  public GetTaskCommand(
   ITaskRepository repository,
   IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseCreator = responseCreator;
  }

  public Task<OperationResultResponse<TaskInfo>> ExecuteAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}


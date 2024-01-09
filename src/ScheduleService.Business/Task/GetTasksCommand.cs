using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class GetTasksCommand : IGetTasksCommand
{
  private readonly ITaskRepository _repository;
  private readonly IResponseCreator _responseCreator;

  public GetTasksCommand(
    ITaskRepository repository,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseCreator = responseCreator;
  }

  public Task<FindResultResponse<List<TaskInfo>>> ExecuteAsync(GetTasksFilter filter)
  {
    throw new NotImplementedException();
  }
}
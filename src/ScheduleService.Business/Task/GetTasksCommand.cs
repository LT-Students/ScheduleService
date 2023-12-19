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

  public GetTasksCommand(
    ITaskRepository repository)
  {
    _repository = repository;
  }

  public Task<FindResultResponse<List<TaskInfo>>> ExecuteAsync(GetTasksFilter filter)
  {
    throw new NotImplementedException();
  }
}
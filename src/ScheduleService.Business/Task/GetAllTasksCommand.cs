using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class GetAllTasksCommand : IGetAllTasksCommand
{
  private readonly ITaskRepository _repository;

  public GetAllTasksCommand(
    ITaskRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<GetTasksResponse>> ExecuteAsync(GetTasksRequest request)
  {
    throw new NotImplementedException();
  }
}
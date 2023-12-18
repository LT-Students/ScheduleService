using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class DeleteTaskCommand : IDeleteTaskCommand
{
  private readonly ITaskRepository _repository;

  public DeleteTaskCommand(
    ITaskRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<DeleteTaskResponse>> ExecuteAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}


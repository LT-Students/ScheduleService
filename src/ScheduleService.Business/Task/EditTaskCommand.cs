using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class EditTaskCommand : IEditTaskCommand
{
  private readonly ITaskRepository _repository;

  public EditTaskCommand(
    ITaskRepository repository)
  {
    _repository = repository;
  }

  public Task<OperationResultResponse<EditTaskResponse>> ExecuteAsync(EditTaskRequest request, Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<OperationResultResponse<EditTaskResponse>> ExecuteAsync(JsonPatchDocument<EditTaskRequest> request, Guid id)
  {
    throw new NotImplementedException();
  }
}


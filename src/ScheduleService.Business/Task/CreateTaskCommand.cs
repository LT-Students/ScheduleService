using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Validation.Task.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task;

public class CreateTaskCommand : ICreateTaskCommand
{
  private readonly ITaskRepository _repository;
  private readonly ICreateTaskRequestValidator _validator;

  public CreateTaskCommand(
    ITaskRepository repository,
    ICreateTaskRequestValidator validator)
  {
    _repository = repository;
    _validator = validator;
  }

  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateTaskRequest request)
  {
    throw new NotImplementedException();
  }
}

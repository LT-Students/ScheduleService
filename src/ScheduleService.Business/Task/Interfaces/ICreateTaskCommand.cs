using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task.Interfaces
{
  [AutoInject]
  public interface ICreateTaskCommand
  {
    Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateTaskRequest request);
  }
}

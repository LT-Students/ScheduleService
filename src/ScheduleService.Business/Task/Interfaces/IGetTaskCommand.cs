using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task.Interfaces
{
  [AutoInject]
  public interface IGetTaskCommand
  {
    Task<OperationResultResponse<GetTaskResponse>> ExecuteAsync(GetTaskRequest request);
  }
}

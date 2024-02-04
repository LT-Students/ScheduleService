using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;

[AutoInject]
public interface IGetTaskCommand
{
  Task<OperationResultResponse<TaskResponse>> ExecuteAsync(Guid id);
}

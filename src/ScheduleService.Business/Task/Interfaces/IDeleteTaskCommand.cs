using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;

[AutoInject]
public interface IDeleteTaskCommand
{
  Task<OperationResultResponse<DeleteTaskResponse>> ExecuteAsync(Guid id);
}


using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;

[AutoInject]
public interface IEditTaskCommand
{
  Task<OperationResultResponse<EditTaskResponse>> ExecuteAsync(JsonPatchDocument<EditTaskRequest> request, Guid id);
  Task<OperationResultResponse<EditTaskResponse>> ExecuteAsync(EditTaskRequest request, Guid id);
}

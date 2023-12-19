using LT.DigitalOffice.Kernel.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Business.Task;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using LT.DigitalOffice.ScheduleService.Models.Dto;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[Route("[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
  [HttpPost]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromBody] CreateTaskRequest request,
    [FromServices] CreateTaskCommand command)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet]
  public async Task<FindResultResponse<List<TaskInfo>>> GetAllAsync(
    [FromQuery] GetTasksFilter filter,
    [FromServices] GetTasksCommand command)
  {
    return await command.ExecuteAsync(filter);
  }

  [HttpGet("{id}")]
  public async Task<OperationResultResponse<TaskInfo>> GetAsync(
    [FromRoute] Guid id,
    [FromServices] GetTaskCommand command)
  {
    return await command.ExecuteAsync(id);
  }

  [HttpPut("{id}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromRoute] Guid id,
    [FromBody] EditTaskRequest request,
    [FromServices] UpdateTaskCommand command)
  {
    return await command.ExecuteAsync(request, id);
  }

  [HttpPatch("{id}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromRoute] Guid id,
    [FromBody] JsonPatchDocument<EditTaskRequest> request,
    [FromServices] EditTaskCommand command)
  {
    return await command.ExecuteAsync(request, id);
  }

  [HttpDelete("{id}")]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromRoute] Guid id,
    [FromServices] DeleteTaskCommand command)
  {
    return await command.ExecuteAsync(id);
  }
}

using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[Route("[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
  [HttpPost]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromBody] CreateTaskRequest request,
    [FromServices] ICreateTaskCommand command)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet]
  public async Task<FindResultResponse<List<TaskInfo>>> GetAllAsync(
    [FromQuery] GetTasksFilter filter,
    [FromServices] IGetTasksCommand command)
  {
    return await command.ExecuteAsync(filter);
  }

  [HttpGet("{id}")]
  public async Task<OperationResultResponse<TaskInfo>> GetAsync(
    [FromRoute] Guid id,
    [FromServices] IGetTaskCommand command)
  {
    return await command.ExecuteAsync(id);
  }

  [HttpPut("{id}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromRoute] Guid id,
    [FromBody] EditTaskRequest request,
    [FromServices] IUpdateTaskCommand command)
  {
    return await command.ExecuteAsync(request, id);
  }

  [HttpPatch("{id}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromRoute] Guid id,
    [FromBody] JsonPatchDocument<EditTaskRequest> request,
    [FromServices] IEditTaskCommand command)
  {
    return await command.ExecuteAsync(request, id);
  }

  [HttpDelete("{id}")]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromRoute] Guid id,
    [FromServices] IRemoveTaskCommand command)
  {
    return await command.ExecuteAsync(id);
  }
}

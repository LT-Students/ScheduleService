using LT.DigitalOffice.Kernel.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.ScheduleService.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class TaskController : ControllerBase
  {
    [HttpPost("create")]
    public async Task<OperationResultResponse<Guid?>> CreateAsync(
      [FromBody] CreateTaskRequest request,
      [FromServices] CreateTaskCommand command)
    {
      return await command.ExecuteAsync(request);
    }

    [HttpGet()]
    public async Task<OperationResultResponse<GetTasksResponse>> GetAllAsync(
      [FromBody] GetTasksRequest request,
      [FromServices] GetAllTasksCommand command)
    {
      return await command.ExecuteAsync(request);
    }

    [HttpGet("{id}")]
    public async Task<OperationResultResponse<GetTaskResponse>> GetAsync(
      [FromRoute] Guid id,
      [FromServices] GetTaskCommand command)
    {
      return await command.ExecuteAsync(id);
    }

    [HttpPatch("{id}")]
    public async Task<OperationResultResponse<EditTaskResponse>> EditAsync(
      [FromRoute] Guid id,
      [FromBody] EditTaskRequest request,
      [FromServices] EditTaskCommand command)
    {
      return await command.ExecuteAsync(request, id);
    }

    [HttpPatch("{id}")]
    public async Task<OperationResultResponse<EditTaskResponse>> EditAsync(
      [FromRoute] Guid id,
      [FromBody] JsonPatchDocument<EditTaskRequest> request,
      [FromServices] EditTaskCommand command)
    {
      return await command.ExecuteAsync(request, id);
    }

    [HttpDelete("{id}")]
    public async Task<OperationResultResponse<DeleteTaskResponse>> DeleteAsync(
      [FromRoute] Guid id,
      [FromServices] DeleteTaskCommand command)
    {
      return await command.ExecuteAsync(id);
    }
  }
}

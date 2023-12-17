using LT.DigitalOffice.Kernel.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using LT.DigitalOffice.ScheduleService.Business.Task;
using Azure;
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

    [HttpGet("get")]
    public async Task<OperationResultResponse<GetTasksResponse>> GetAllAsync(
      [FromBody] GetTasksRequest request,
      [FromServices] GetTasksCommand command)
    {
      return await command.ExecuteAsync(request);
    }

    [HttpGet("get")]
    public async Task<OperationResultResponse<GetTaskResponse>> GetAsync(
      [FromBody] GetTaskRequest request,
      [FromServices] GetTaskCommand command)
    {
      return await command.ExecuteAsync(request);
    }

    [HttpPatch("edit")]
    public async Task<OperationResultResponse<EditTaskResponse>> EditAsync(
      [FromBody] EditTaskRequest request,
      [FromServices] EditTaskCommand command)
    {
      return await command.ExecuteAsync(request);
    }

    [HttpPatch("edit")]
    public async Task<OperationResultResponse<EditTaskResponse>> EditAsync(
      [FromBody] JsonPatchDocument<EditTaskRequest> request,
      [FromServices] EditTaskCommand command)
    {
      return await command.ExecuteAsync(request);
    }

    [HttpDelete("delete")]
    public async Task<OperationResultResponse<DeleteTaskResponse>> DeleteAsync(
      [FromBody] DeleteTaskRequest request,
      [FromServices] DeleteTaskCommand command)
    {
      return await command.ExecuteAsync(request);
    }
  }
}

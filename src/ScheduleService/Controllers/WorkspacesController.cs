using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using System;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using Microsoft.AspNetCore.JsonPatch;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

namespace LT.DigitalOffice.DepartmentService.Controllers;

[Route("[controller]")]
[ApiController]
public class WorkspacesController : ControllerBase
{
  [HttpGet("get")]
  public async Task<OperationResultResponse<WorkspaceResponse>> GetAsync(
    [FromServices] IGetWorkspaceCommand command,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id);
  }

  [HttpGet("find")]
  public async Task<FindResultResponse<WorkspaceResponse>> GetAllAsync(
    [FromServices] IFindWorkspacesCommand command,
    [FromQuery] FindWorkspaceFilter request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpPost("create")]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateWorkspaceCommand command,
    [FromBody] CreateWorkspaceRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpPatch("edit")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromServices] IEditWorkspaceCommand command,
    [FromBody] JsonPatchDocument<EditWorkspaceRequest> request,
    [FromRoute] Guid id)
  {
    return await command.ExecuteAsync(id, request);
  }

  [HttpPut("update")]
  public async Task<OperationResultResponse<bool>> UpdateAsync(
    [FromServices] IUpdateWorkspaceCommand command,
    [FromBody] EditWorkspaceRequest request,
    [FromRoute] Guid id)
  {
    return await command.ExecuteAsync(id, request);
  }

  [HttpDelete("remove")]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromServices] IRemoveWorkspaceCommand command,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id);
  }
}

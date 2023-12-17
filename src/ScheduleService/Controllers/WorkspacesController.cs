using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using System;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.DepartmentService.Controllers;

[Route("[controller]")]
[ApiController]
public class WorkspacesController : ControllerBase
{
  [HttpGet("{id}")]
  public async Task<OperationResultResponse<Guid?>> GetAsync(
    [FromServices] IGetWorkspaceCommand command,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id);
  }

  [HttpGet()]
  public async Task<FindResultResponse<WorkspaceInfo>> GetAllAsync(
    [FromServices] IGetWorkspacesCommand command,
    [FromQuery] GetWorkspacesFilter request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPost()]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateWorkspaceCommand command,
    [FromBody] CreateWorkspaceRequest request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPatch("{id}")]
  public async Task<OperationResultResponse<Guid?>> EditAsync(
    [FromServices] IEditWorkspaceCommand command,
    [FromBody] JsonPatchDocument<EditWorkspaceRequest> request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpPut("{id}")]
  public async Task<OperationResultResponse<Guid?>> UpdateAsync(
    [FromServices] IUpdateWorkspaceCommand command,
    [FromBody] UpdateWorkspaceRequest request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpDelete("{id}")]
  public async Task<OperationResultResponse<Guid?>> DeleteAsync(
    [FromServices] IDeleteWorkspaceCommand command,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id);
  }
}

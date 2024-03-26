using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using System;
using LT.DigitalOffice.Kernel.Responses;
using Microsoft.AspNetCore.JsonPatch;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using Swashbuckle.AspNetCore.Annotations;
using DigitalOffice.Kernel.OpenApi.OperationFilters;
using Microsoft.AspNetCore.Http;

namespace LT.DigitalOffice.SheduleService.Controllers;

[Route("[controller]")]
[Produces("application/json")]
[Consumes("application/json")]
[ApiController]
public class WorkspacesController : ControllerBase
{
  /// <summary>
  /// Get workspace.
  /// </summary>
  [HttpGet("get")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<WorkspaceResponse>), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<WorkspaceResponse>), StatusCodes.Status404NotFound)]
  public async Task<OperationResultResponse<WorkspaceResponse>> GetAsync(
    [FromServices] IGetWorkspaceCommand command,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id);
  }

  /// <summary>
  /// Find workspaces.
  /// </summary>
  [HttpGet("find")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(FindResultResponse<WorkspaceResponse>), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<FindResultResponse<WorkspaceResponse>> GetAllAsync(
    [FromServices] IFindWorkspacesCommand command,
    [FromQuery] FindWorkspaceFilter request)
  {
    return await command.ExecuteAsync(request);
  }

  /// <summary>
  /// Create workspace.
  /// </summary>
  [HttpPost("create")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<Guid?>), StatusCodes.Status201Created)]
  [ProducesResponseType(typeof(OperationResultResponse<Guid?>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateWorkspaceCommand command,
    [FromBody] CreateWorkspaceRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  /// <summary>
  /// Edit workspace.
  /// </summary>
  [HttpPatch("edit")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status403Forbidden)]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromServices] IEditWorkspaceCommand command,
    [FromBody] JsonPatchDocument<EditWorkspaceRequest> request,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id, request);
  }

  /// <summary>
  /// Update workspace.
  /// </summary>
  [HttpPut("update")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status403Forbidden)]
  public async Task<OperationResultResponse<bool>> UpdateAsync(
    [FromServices] IUpdateWorkspaceCommand command,
    [FromBody] EditWorkspaceRequest request,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id, request);
  }

  /// <summary>
  /// Remove workspace.
  /// </summary>
  [HttpDelete("remove")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status404NotFound)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status403Forbidden)]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromServices] IRemoveWorkspaceCommand command,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id);
  }
}

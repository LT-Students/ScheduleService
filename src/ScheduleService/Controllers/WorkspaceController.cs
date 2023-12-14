using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using System;

namespace LT.DigitalOffice.DepartmentService.Controllers;

[Route("[controller]")]
[ApiController]
public class WorkspaceController : ControllerBase
{
  [HttpGet("get/{id}")]
  public async Task<IActionResult> GetAsync(
    [FromServices] IGetWorkspaceCommand command,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id);
  }

  [HttpGet("get")]
  public async Task<IActionResult> GetAllAsync(
    [FromServices] IGetWorkspacesCommand command,
    [FromQuery] GetWorkspacesFilter request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPost("create")]
  public async Task<IActionResult> CreateAsync(
    [FromServices] ICreateWorkspaceCommand command,
    [FromBody] CreateWorkspaceRequest request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPatch("edit/{id}")]
  public async Task<IActionResult> PatchAsync(
    [FromServices] IPatchWorkspaceCommand command,
    [FromBody] PatchWorkspaceRequest request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpPut("update/{id}")]
  public async Task<IActionResult> PutAsync(
    [FromServices] IPutWorkspaceCommand command,
    [FromBody] PutWorkspaceRequest request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpDelete("delete/{id}")]
  public async Task<IActionResult> DeleteAsync(
    [FromServices] IDeleteWorkspaceCommand command,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id);
  }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;

namespace LT.DigitalOffice.DepartmentService.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class WorkspaceController : ControllerBase
  {
    [HttpGet("get")]
    public async Task<IActionResult> GetAsync(
      [FromServices] IGetWorkspaceCommand command,
      [FromBody] GetWorkspaceRequest request)
    {

      return await command.ExecuteAsync(request);
    }

    [HttpGet("find")]
    public async Task<IActionResult> FindAsync(
      [FromServices] IFindWorkspaceCommand command,
      [FromQuery] FindWorkspacesFilter request)
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

    [HttpPatch("update")]
    public async Task<IActionResult> PatchAsync(
      [FromServices] IPatchWorkspaceCommand command,
      [FromBody] PatchWorkspaceRequest request)
    {

      return await command.ExecuteAsync(request);
    }

    [HttpPut("edit")]
    public async Task<IActionResult> PutAsync(
      [FromServices] IPutWorkspaceCommand command,
      [FromBody] PutWorkspaceRequest request)
    {

      return await command.ExecuteAsync(request);
    }

    [HttpDelete("remove")]
    public async Task<IActionResult> DeleteAsync(
      [FromServices] IDeleteWorkspaceCommand command,
      [FromBody] DeleteWorkspaceRequest request)
    {

      return await command.ExecuteAsync(request);
    }
  }
}

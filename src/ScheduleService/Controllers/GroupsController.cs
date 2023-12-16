using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[Route("[controller]")]
[ApiController]
public class GroupsController
{
  [HttpPost]
  public async Task<OperationResultResponse<CreateGroupResponse>> CreateAsync(
    [FromServices] ICreateGroupCommand command,
    [FromBody] CreateGroupRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet]
  public async Task<OperationResultResponse<FindGroupResponse>> FindAsync(
    [FromServices] IFindGroupCommand command,
    [FromBody] FindGroupRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet("findAll")]
  public async Task<OperationResultResponse<FindGroupsResponse>> CreateAsync(
    [FromServices] IFindGroupsCommand command,
    [FromBody] FindGroupsRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpDelete]
  public async Task<OperationResultResponse<DeleteGroupResponse>> CreateAsync(
    [FromServices] IDeleteGroupCommand command,
    [FromBody] DeleteGroupRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpPatch]
  public async Task<OperationResultResponse<UpdateGroupResponse>> CreateAsync(
  [FromServices] IUpdateGroupCommand command,
  [FromBody] UpdateGroupRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpPut]
  public async Task<OperationResultResponse<EditGroupResponse>> CreateAsync(
  [FromServices] IEditGroupCommand command,
  [FromBody] EditGroupRequest request)
  {
    return await command.ExecuteAsync(request);
  }
}

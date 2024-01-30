using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[ApiController]
[Route("[Controller]")]
public class GroupsUsersController : ControllerBase
{
  [HttpPost]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateGroupUserCommand command,
    [FromBody] CreateGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpDelete("{id}")]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromServices] IRemoveGroupUserCommand command,
    [FromRoute] Guid id)
  {
    return await command.ExecuteAsync(id);
  }

  [HttpPatch("{id}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromServices] IEditGroupUserCommand command,
    [FromRoute] Guid id,
    [FromBody] JsonPatchDocument<EditGroupUserRequest> request)
  {
    return await command.ExecuteAsync(request, id);
  }

  [HttpPut("{id}")]
  public async Task<OperationResultResponse<bool>> UpdateAsync(
    [FromServices] IUpdateGroupUserCommand command,
    [FromRoute] Guid id,
    [FromBody] EditGroupUserRequest request)
  {
    return await command.ExecuteAsync(request, id);
  }

  [HttpGet("{id}")]
  public async Task<OperationResultResponse<GroupUserInfo>> FindAsync(
    [FromServices] IGetGroupUserCommand command,
    [FromBody] GetGroupUserFilter request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet]
  public async Task<OperationResultResponse<FindResultResponse<GroupUserInfo>>> FindsAsync(
    [FromServices] IGetGroupsUsersCommand command,
    [FromQuery] GetGroupsUsersFilter request)
  {
    return await command.ExecuteAsync(request);
  }
}

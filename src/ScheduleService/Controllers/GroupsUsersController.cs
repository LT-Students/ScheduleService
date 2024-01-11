using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
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
      [FromServices] IDeleteGroupUserCommand command,
      [FromRoute] Guid id)
  {
    return await command.ExecuteAsync(id);
  }

  [HttpPut("{id}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
      [FromServices] IEditGroupUserCommand command,
      [FromRoute] Guid id,
      [FromBody] EditGroupUserRequest request)
  {
    return await command.ExecuteAsync(id, request);
  }

  [HttpPatch("{id}")]
  public async Task<OperationResultResponse<UpdateGroupUserResponse>> UpdateAsync(
      [FromServices] IUpdateGroupUserCommand command,
      [FromBody] UpdateGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
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

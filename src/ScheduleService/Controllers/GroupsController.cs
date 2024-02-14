using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[Route("[controller]")]
[ApiController]
public class GroupsController
{
  [HttpPost]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateGroupCommand command,
    [FromBody] CreateGroupRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet("{groupId}")]
  public async Task<OperationResultResponse<GroupResponse>> FindAsync(
    [FromServices] IGetGroupCommand command,
    [FromRoute] Guid groupId)
  {
    return await command.ExecuteAsync(groupId);
  }

  [HttpGet]
  public async Task<OperationResultResponse<FindResultResponse<GroupResponse>>> FindsAsync(
    [FromServices] IGetGroupsCommand command,
    [FromQuery] GetGroupsFilter filter)
  {
    return await command.ExecuteAsync(filter);
  }

  [HttpDelete("{groupId}")]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromServices] IDeleteGroupCommand command,
    [FromRoute] Guid groupId)
  {
    return await command.ExecuteAsync(groupId);
  }

  [HttpPut("{groupId}")]
  public async Task<OperationResultResponse<bool>> UpdateAsync(
    [FromServices] IUpdateGroupCommand command,
    [FromRoute] Guid groupId,
    [FromBody] EditGroupRequest request)
  {
    return await command.ExecuteAsync(groupId, request);
  }

  [HttpPatch("{groupId}")]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromServices] IEditGroupCommand command,
    [FromRoute] Guid groupId,
    [FromBody] JsonPatchDocument<EditGroupRequest> request)
  {
    return await command.ExecuteAsync(groupId, request);
  }
}

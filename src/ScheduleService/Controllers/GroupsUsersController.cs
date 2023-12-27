using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.GroupUser;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Controllers;

[ApiController]
[Route("[Controller]")]
public class GroupsUsersController : ControllerBase
{
  [HttpPost]
  public async Task<OperationResultResponse<CreateGroupUserResponse>> CreateAsync(
      [FromServices] ICreateGroupUserCommand command,
      [FromBody] CreateGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpDelete]
  public async Task<OperationResultResponse<DeleteGroupUserResponse>> DeleteAsync(
      [FromServices] IDeleteGroupUserCommand command,
      [FromBody] DeleteGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpPut]
  public async Task<OperationResultResponse<EditGroupUserResponse>> EditAsync(
      [FromServices] IEditGroupUserCommand command,
      [FromBody] EditGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpPatch]
  public async Task<OperationResultResponse<UpdateGroupUserResponse>> UpdateAsync(
      [FromServices] IUpdateGroupUserCommand command,
      [FromBody] UpdateGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet]
  public async Task<OperationResultResponse<FindGroupUserResponse>> FindAsync(
      [FromServices] IFindGroupUserCommand command,
      [FromBody] FindGroupUserRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  [HttpGet("findAll")]
  public async Task<OperationResultResponse<FindGroupsUsersResponse>> FindsAsync(
      [FromServices] IFindGroupsUsersCommand command,
      [FromBody] FindGroupsUsersRequest request)
  {
    return await command.ExecuteAsync(request);
  }
}

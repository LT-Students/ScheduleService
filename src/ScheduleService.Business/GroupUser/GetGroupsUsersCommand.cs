using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System.Threading.Tasks;
using System;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class GetGroupsUsersCommand : IGetGroupsUsersCommand
{
  private readonly IGroupUserRepository _repository;
  private readonly IResponseCreator _responseCreator;

  public GetGroupsUsersCommand(
    IGroupUserRepository repository,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseCreator = responseCreator;
  }

  public Task<OperationResultResponse<FindResultResponse<GroupUserInfo>>> ExecuteAsync(GetGroupsUsersFilter request)
  {
    throw new NotImplementedException();
  }
}

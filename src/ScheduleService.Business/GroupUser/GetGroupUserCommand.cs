using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class GetGroupUserCommand : IGetGroupUserCommand
{
  private readonly IGroupUserRepository _repository;
  private readonly IResponseCreator _responseCreator;

  public GetGroupUserCommand(
    IGroupUserRepository repository,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseCreator = responseCreator;
  }

  public Task<OperationResultResponse<GroupUserInfo>> ExecuteAsync(GetGroupUserFilter request)
  {
    throw new NotImplementedException();
  }
}

using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class GetGroupsCommand : IGetGroupsCommand
{
  private readonly IGroupRepository _repository;
  private readonly IResponseCreator _responseCreator;

  public GetGroupsCommand(
    IGroupRepository repository,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseCreator = responseCreator;
  }

  public Task<OperationResultResponse<FindResultResponse<GroupResponse>>> ExecuteAsync(GetGroupsFilter request)
  {
    throw new NotImplementedException();
  }
}

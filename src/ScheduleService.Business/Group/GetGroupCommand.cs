using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class GetGroupCommand : IGetGroupCommand
{
  private readonly IGroupRepository _repository;
  private readonly IResponseCreator _responseCreator;

  public GetGroupCommand(
    IGroupRepository repository,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseCreator = responseCreator;
  }

  public Task<OperationResultResponse<GroupInfo>> ExecuteAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}

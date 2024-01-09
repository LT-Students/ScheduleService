using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class GetGroupCommand : IGetGroupCommand
{
  public Task<OperationResultResponse<GroupInfo>> ExecuteAsync(Guid id)
  {
    throw new System.NotImplementedException();
  }
}

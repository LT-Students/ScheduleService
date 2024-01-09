using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class CreateGroupCommand : ICreateGroupCommand
{
  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateGroupRequest request)
  {
    throw new System.NotImplementedException();
  }
}

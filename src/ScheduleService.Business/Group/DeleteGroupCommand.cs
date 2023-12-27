using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class DeleteGroupCommand : IDeleteGroupCommand
{
  public Task<OperationResultResponse<DeleteGroupResponse>> ExecuteAsync(DeleteGroupRequest request)
  {
    throw new System.NotImplementedException();
  }
}

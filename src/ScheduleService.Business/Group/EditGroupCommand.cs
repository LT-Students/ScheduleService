using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class EditGroupCommand : IEditGroupCommand
{
  public Task<OperationResultResponse<EditGroupResponse>> ExecuteAsync(EditGroupRequest request)
  {
    throw new System.NotImplementedException();
  }
}

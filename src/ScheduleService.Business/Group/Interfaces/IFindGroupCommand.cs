using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;

public interface IFindGroupCommand
{
  Task<OperationResultResponse<FindGroupResponse>> ExecuteAsync(FindGroupRequest request);
}

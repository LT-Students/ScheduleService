using LT.DigitalOffice.Kernel.Responses;
using System.Threading.Tasks;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses.Group;
using LT.DigitalOffice.Kernel.Attributes;

namespace LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;

[AutoInject]
public interface ICreateGroupCommand
{
  Task<OperationResultResponse<CreateGroupResponse>> ExecuteAsync(CreateGroupRequest request);
}

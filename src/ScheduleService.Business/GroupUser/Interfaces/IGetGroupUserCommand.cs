using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;

[AutoInject]
public interface IGetGroupUserCommand
{
  Task<OperationResultResponse<GroupUserInfo>> ExecuteAsync(GetGroupUserFilter request);
}

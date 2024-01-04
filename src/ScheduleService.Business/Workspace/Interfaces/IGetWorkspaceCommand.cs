using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;

[AutoInject]
public interface IGetWorkspaceCommand
{
  Task<OperationResultResponse<WorkspaceResponse>> ExecuteAsync(Guid id);
}

using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;

[AutoInject]
public interface IRemoveWorkspaceCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(Guid id);
}

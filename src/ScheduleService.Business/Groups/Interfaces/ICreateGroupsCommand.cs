using LT.DigitalOffice.Kernel.Responses;
using System.Threading.Tasks;
using System;

namespace LT.DigitalOffice.ScheduleService.Business.Groups.Interfaces;

public interface ICreateGroupsCommand
{
  Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateCategoryRequest request);
}

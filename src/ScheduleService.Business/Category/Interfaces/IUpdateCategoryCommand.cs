using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;

[AutoInject]
public interface IUpdateCategoryCommand
{
  Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id, UpdateCategoryRequest request);
}

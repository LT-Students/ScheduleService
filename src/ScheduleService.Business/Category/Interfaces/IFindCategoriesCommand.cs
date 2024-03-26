using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;

[AutoInject]
public interface IFindCategoriesCommand
{
  Task<FindResultResponse<CategoryResponse>> ExecuteAsync(FindCategoriesFilter request, CancellationToken cancellationToken = default);
}

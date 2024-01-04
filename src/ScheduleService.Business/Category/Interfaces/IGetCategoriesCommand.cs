using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;

[AutoInject]
public interface IGetCategoriesCommand
{
  Task<FindResultResponse<CategoryInfo>> ExecuteAsync(GetCategoriesFilter request);
}

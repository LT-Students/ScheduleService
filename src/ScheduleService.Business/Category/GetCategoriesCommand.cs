using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoriesCommand : IGetCategoriesCommand
{
    public Task<FindResultResponse<CategoryInfo>> ExecuteAsync(GetCategoriesFilter request)
    {
        throw new System.NotImplementedException();
    }
}

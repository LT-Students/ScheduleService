using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category
{
  public class FindCategoryCommand : IFindCategoryCommand
  {
    public Task<IActionResult> ExecuteAsync(FindCategoriesFilter request)
    {
      throw new System.NotImplementedException();
    }
  }
}

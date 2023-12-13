using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category
{
  public class GetCategoryCommand : IGetCategoryCommand
  {
    public Task<IActionResult> ExecuteAsync(GetCategoryRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

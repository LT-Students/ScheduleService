using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category
{
  public class PatchCategoryCommand : IPatchCategoryCommand
  {
    public Task<IActionResult> ExecuteAsync(PatchCategoryRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

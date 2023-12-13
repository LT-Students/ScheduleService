using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category
{
  public class CreateCategoryCommand : ICreateCategoryCommand
  {
    public Task<IActionResult> ExecuteAsync(CreateCategoryRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

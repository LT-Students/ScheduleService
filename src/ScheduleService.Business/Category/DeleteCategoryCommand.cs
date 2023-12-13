using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category
{
  public class DeleteCategoryCommand : IDeleteCategoryCommand
  {
    public Task<IActionResult> ExecuteAsync(DeleteCategoryRequest request)
    {
      throw new System.NotImplementedException();
    }
  }
}

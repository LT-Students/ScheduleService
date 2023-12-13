using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category.Interfaces
{
  [AutoInject]
  public interface ICreateCategoryCommand
  {
    Task<IActionResult> ExecuteAsync(CreateCategoryRequest request);
    }
}

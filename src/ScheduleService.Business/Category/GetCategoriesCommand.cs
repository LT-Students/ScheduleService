using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoriesCommand : IGetCategoriesCommand
{
  public Task<IActionResult> ExecuteAsync(GetCategoriesFilter request)
  {
    throw new System.NotImplementedException();
  }
}

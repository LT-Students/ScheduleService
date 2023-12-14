using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoryCommand : IGetCategoryCommand
{
  public Task<IActionResult> ExecuteAsync(Guid id)
  {
    throw new System.NotImplementedException();
  }
}

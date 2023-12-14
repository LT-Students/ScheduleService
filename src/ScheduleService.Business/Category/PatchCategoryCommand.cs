using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class PatchCategoryCommand : IPatchCategoryCommand
{
  public Task<IActionResult> ExecuteAsync(Guid id, PatchCategoryRequest request)
  {
    throw new System.NotImplementedException();
  }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using System;

namespace LT.DigitalOffice.DepartmentService.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
  [HttpGet("get/{id}")]
  public async Task<IActionResult> GetAsync(
    [FromServices] IGetCategoryCommand command,
    [FromRoute] Guid id)
    {

      return await command.ExecuteAsync(id);
    }

  [HttpGet("get")]
  public async Task<IActionResult> GetAllAsync(
    [FromServices] IGetCategoriesCommand command,
    [FromQuery] GetCategoriesFilter request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPost("create")]
  public async Task<IActionResult> CreateAsync(
    [FromServices] ICreateCategoryCommand command,
    [FromBody] CreateCategoryRequest request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPatch("edit/{id}")]
  public async Task<IActionResult> PatchAsync(
    [FromServices] IPatchCategoryCommand command,
    [FromBody] PatchCategoryRequest request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpPut("update/{id}")]
  public async Task<IActionResult> PutAsync(
    [FromServices] IPutCategoryCommand command,
    [FromBody] PutCategoryRequest request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpDelete("delete/{id}")]
  public async Task<IActionResult> DeleteAsync(
    [FromServices] IDeleteCategoryCommand command,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id);
  }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;

namespace LT.DigitalOffice.DepartmentService.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class CategoryController : ControllerBase
  {
    [HttpGet("get")]
    public async Task<IActionResult> GetAsync(
      [FromServices] IGetCategoryCommand command,
      [FromBody] GetCategoryRequest request)
    {

      return await command.ExecuteAsync(request);
    }

    [HttpGet("find")]
    public async Task<IActionResult> FindAsync(
      [FromServices] IFindCategoryCommand command,
      [FromQuery] FindCategoriesFilter request)
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

    [HttpPatch("update")]
    public async Task<IActionResult> PatchAsync(
      [FromServices] IPatchCategoryCommand command,
      [FromBody] PatchCategoryRequest request)
    {

      return await command.ExecuteAsync(request);
    }

    [HttpPut("edit")]
    public async Task<IActionResult> PutAsync(
      [FromServices] IPutCategoryCommand command,
      [FromBody] PutCategoryRequest request)
    {

      return await command.ExecuteAsync(request);
    }

    [HttpDelete("remove")]
    public async Task<IActionResult> DeleteAsync(
      [FromServices] IDeleteCategoryCommand command,
      [FromBody] DeleteCategoryRequest request)
    {

      return await command.ExecuteAsync(request);
    }
  }
}

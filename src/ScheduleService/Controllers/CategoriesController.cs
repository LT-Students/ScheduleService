using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using System;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Models.Dto.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace LT.DigitalOffice.DepartmentService.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
  [HttpGet("{id}")]
  public async Task<OperationResultResponse<Guid?>> GetAsync(
    [FromServices] IGetCategoryCommand command,
    [FromRoute] Guid id)
    {

      return await command.ExecuteAsync(id);
    }

  [HttpGet()]
  public async Task<FindResultResponse<CategoryInfo>> GetAllAsync(
    [FromServices] IGetCategoriesCommand command,
    [FromQuery] GetCategoriesFilter request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPost()]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateCategoryCommand command,
    [FromBody] CreateCategoryRequest request)
  {

    return await command.ExecuteAsync(request);
  }

  [HttpPatch("{id}")]
  public async Task<OperationResultResponse<Guid?>> EditAsync(
    [FromServices] IEditCategoryCommand command,
    [FromBody] JsonPatchDocument<EditCategoryRequest> request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpPut("{id}")]
  public async Task<OperationResultResponse<Guid?>> UpdateAsync(
    [FromServices] IUpdateCategoryCommand command,
    [FromBody] UpdateCategoryRequest request,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id, request);
  }

  [HttpDelete("{id}")]
  public async Task<OperationResultResponse<Guid?>> DeleteAsync(
    [FromServices] IDeleteCategoryCommand command,
    [FromRoute] Guid id)
  {

    return await command.ExecuteAsync(id);
  }
}

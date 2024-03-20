using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using System;
using LT.DigitalOffice.Kernel.Responses;
using Microsoft.AspNetCore.JsonPatch;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using DigitalOffice.Kernel.OpenApi.OperationFilters;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace LT.DigitalOffice.DepartmentService.Controllers;

[Route("[controller]")]
[Produces("application/json")]
[Consumes("application/json")]

[ApiController]
public class CategoriesController : ControllerBase
{
  /// <summary>
  /// Get category.
  /// </summary>
  [HttpGet("get")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<CategoryResponse>), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<CategoryResponse>), StatusCodes.Status404NotFound)]
  public async Task<OperationResultResponse<CategoryResponse>> GetAsync(
    [FromServices] IGetCategoryCommand command,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id);
  }

  /// <summary>
  /// Find category.
  /// </summary>
  [HttpGet("find")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(FindResultResponse<CategoryResponse>), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<FindResultResponse<CategoryResponse>> GetAllAsync(
    [FromServices] IFindCategoriesCommand command,
    [FromQuery] FindCategoriesFilter filter)
  {
    return await command.ExecuteAsync(filter);
  }

  /// <summary>
  /// Create category.
  /// </summary>
  [HttpPost("create")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<Guid?>), StatusCodes.Status201Created)]
  [ProducesResponseType(typeof(OperationResultResponse<Guid?>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<OperationResultResponse<Guid?>> CreateAsync(
    [FromServices] ICreateCategoryCommand command,
    [FromBody] CreateCategoryRequest request)
  {
    return await command.ExecuteAsync(request);
  }

  /// <summary>
  /// Edit category.
  /// </summary>
  [HttpPatch("edit")]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status403Forbidden)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status404NotFound)]
  public async Task<OperationResultResponse<bool>> EditAsync(
    [FromServices] IEditCategoryCommand command,
    [FromBody] JsonPatchDocument<EditCategoryRequest> request,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id, request);
  }

  /// <summary>
  /// Update category.
  /// </summary>
  [HttpPut("update")]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status403Forbidden)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status404NotFound)]
  public async Task<OperationResultResponse<bool>> UpdateAsync(
    [FromServices] IUpdateCategoryCommand command,
    [FromBody] EditCategoryRequest request,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id, request);
  }

  /// <summary>
  /// Remove category.
  /// </summary>
  [HttpDelete("remove")]
  [SwaggerOperationFilter(typeof(TokenOperationFilter))]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status403Forbidden)]
  [ProducesResponseType(typeof(OperationResultResponse<bool>), StatusCodes.Status404NotFound)]
  public async Task<OperationResultResponse<bool>> DeleteAsync(
    [FromServices] IRemoveCategoryCommand command,
    [FromQuery] Guid id)
  {
    return await command.ExecuteAsync(id);
  }
}

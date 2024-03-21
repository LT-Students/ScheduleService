using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Extensions;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class RemoveCategoryCommand : IRemoveCategoryCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public RemoveCategoryCommand(
    ICategoryRepository repository,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator)
	{
		_httpContextAccessor = httpContextAccessor;
		_repository = repository;
		_accessValidator = accessValidator;
		_responseCreator = responseCreator;
	}

  public async Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, CancellationToken ct = default)
  {
    DbCategory dbCategory = await _repository.GetAsync(id, ct);

    if (dbCategory is null)
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.NotFound);
    }

    Guid modifiedBy = _httpContextAccessor.HttpContext.GetUserId();

    if (modifiedBy != dbCategory.CreatedBy && !await _accessValidator.IsAdminAsync(modifiedBy))
    {
      return _responseCreator.CreateFailureResponse<bool>(HttpStatusCode.Forbidden);
    }

    return new OperationResultResponse<bool>
    {
      Body = await _repository.RemoveAsync(dbCategory, modifiedBy)
    };
  }
}

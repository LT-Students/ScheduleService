using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
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

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    throw new NotImplementedException();
  }
}

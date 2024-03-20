using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoryCommand : IGetCategoryCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ICategoryRepository _repository;
  private readonly ICategoryResponseMapper _mapper;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public GetCategoryCommand(
    ICategoryRepository repository,
    ICategoryResponseMapper mapper,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator)
	{
		_httpContextAccessor = httpContextAccessor;
		_repository = repository;
    _mapper = mapper;
		_accessValidator = accessValidator;
		_responseCreator = responseCreator;
	}

  public async Task<OperationResultResponse<CategoryResponse>> ExecuteAsync(Guid id, CancellationToken cancellationToken = default)
  {
    DbCategory dbCategory = await _repository.GetAsync(id, cancellationToken);

    if (dbCategory is null)
    {
      return _responseCreator.CreateFailureResponse<CategoryResponse>(HttpStatusCode.NotFound);
    }

    return new OperationResultResponse<CategoryResponse>(_mapper.Map(dbCategory));
  }
}

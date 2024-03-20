using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category.Filters;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class FindCategoriesCommand : IFindCategoriesCommand
{
  private readonly ICategoryRepository _repository;
  private readonly ICategoryResponseMapper _mapper;

  public FindCategoriesCommand(
    ICategoryRepository repository,
    ICategoryResponseMapper mapper)
  {
    _repository = repository;
    _mapper = mapper;
  }

  public async Task<FindResultResponse<CategoryResponse>> ExecuteAsync(FindCategoriesFilter filter, CancellationToken cancellationToken = default)
  {
    (List<DbCategory> dbCategories, int totalCount) = await _repository.FindAsync(filter, cancellationToken);

    if (dbCategories is null || dbCategories.Count == 0)
    {
      return new FindResultResponse<CategoryResponse>();
    }

    return new FindResultResponse<CategoryResponse>
    {
      Body = dbCategories.ConvertAll(_mapper.Map),
      TotalCount = totalCount
    };
  }
}

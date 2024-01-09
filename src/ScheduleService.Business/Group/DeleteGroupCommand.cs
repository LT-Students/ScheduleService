using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class DeleteGroupCommand : IDeleteGroupCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IGroupRepository _repository;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public DeleteGroupCommand(
    IHttpContextAccessor httpContextAccessor,
    IGroupRepository repository,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    throw new System.NotImplementedException();
  }
}

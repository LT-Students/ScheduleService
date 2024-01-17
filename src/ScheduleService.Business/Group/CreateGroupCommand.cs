using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class CreateGroupCommand : ICreateGroupCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IGroupRepository _repository;
  private readonly ICreateGroupRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;
  private readonly IDbGroupMapper _dbGroupMapper;

  public CreateGroupCommand(
    IHttpContextAccessor httpContextAccessor,
    IGroupRepository repository,
    ICreateGroupRequestValidator validator,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator,
    IDbGroupMapper dbGroupMapper)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
    _dbGroupMapper = dbGroupMapper;
  }

  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateGroupRequest request)
  {
    throw new NotImplementedException();
  }
}

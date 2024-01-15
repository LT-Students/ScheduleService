using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Validation.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Validation.Task.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class CreateGroupUserCommand : ICreateGroupUserCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IGroupUserRepository _repository;
  private readonly ICreateGroupUserRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;
  private readonly IDbGroupUserMapper _dbTaskMapper;

  public CreateGroupUserCommand(
    IHttpContextAccessor httpContextAccessor,
    IGroupUserRepository repository,
    ICreateGroupUserRequestValidator validator,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator,
    IDbGroupUserMapper dbTaskMapper)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
    _dbTaskMapper = dbTaskMapper;
  }

  public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateGroupUserRequest request)
  {
    throw new NotImplementedException();
  }
}

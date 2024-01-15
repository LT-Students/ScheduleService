using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.GroupUser.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.GroupUser;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Tasks;
using LT.DigitalOffice.ScheduleService.Validation.GroupUser.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.GroupUser;

public class EditGroupUserCommand : IEditGroupUserCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IGroupUserRepository _repository;
  private readonly IEditGroupUserRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public EditGroupUserCommand(
    IHttpContextAccessor httpContextAccessor,
    IGroupUserRepository repository,
    IEditGroupUserRequestValidator validator,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(JsonPatchDocument<EditGroupUserRequest> request, Guid id)
  {
    throw new NotImplementedException();
  }
}

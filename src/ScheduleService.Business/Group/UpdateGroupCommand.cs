using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class UpdateGroupCommand : IUpdateGroupCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IGroupRepository _repository;
  private readonly IEditGroupRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public UpdateGroupCommand(
    IHttpContextAccessor httpContextAccessor,
    IGroupRepository repository,
    IEditGroupRequestValidator validator,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, JsonPatchDocument<EditGroupRequest> request)
  {
    throw new NotImplementedException();
  }
}

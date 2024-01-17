using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Mappers.Patch.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Group;
using LT.DigitalOffice.ScheduleService.Validation.Group.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class EditGroupCommand : IEditGroupCommand
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IGroupRepository _repository;
  private readonly IEditGroupRequestValidator _validator;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;
  private readonly IPatchDbGroupMapper _patchDbGroupMapper;

  public EditGroupCommand(
    IHttpContextAccessor httpContextAccessor,
    IGroupRepository repository,
    IEditGroupRequestValidator validator,
    IResponseCreator responseCreator,
    IAccessValidator accessValidator,
    IPatchDbGroupMapper patchDbGroupMapper)
  {
    _httpContextAccessor = httpContextAccessor;
    _repository = repository;
    _validator = validator;
    _responseCreator = responseCreator;
    _accessValidator = accessValidator;
    _patchDbGroupMapper = patchDbGroupMapper;
  }

  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id, EditGroupRequest request)
  {
    throw new NotImplementedException();
  }
}

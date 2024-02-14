﻿using LT.DigitalOffice.Kernel.BrokerSupport.AccessValidatorEngine.Interfaces;
using LT.DigitalOffice.Kernel.Helpers.Interfaces;
using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Data.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace.Filters;
using LT.DigitalOffice.Kernel.Validators.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using LT.DigitalOffice.ScheduleService.Models.Db;
using System.Linq;
using LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class FindWorkspacesCommand : IFindWorkspacesCommand
{
  private readonly IWorkspaceRepository _repository;
  private readonly IWorkspaceResponseMapper _responseMapper;
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly IResponseCreator _responseCreator;
  private readonly IAccessValidator _accessValidator;

  public FindWorkspacesCommand(
    IWorkspaceRepository repository,
    IWorkspaceResponseMapper responseMapper,
    IAccessValidator accessValidator,
    IHttpContextAccessor httpContextAccessor,
    IResponseCreator responseCreator)
  {
    _repository = repository;
    _responseMapper = responseMapper;
    _accessValidator = accessValidator;
    _httpContextAccessor = httpContextAccessor;
    _responseCreator = responseCreator;
  }

  public async Task<FindResultResponse<WorkspaceResponse>> ExecuteAsync(FindWorkspaceFilter filter)
  {
    (List<DbWorkspace> dbWorkspaces, int totalCount) = await _repository.FindAsync(filter);

    if (dbWorkspaces is null || !dbWorkspaces.Any())
    {
      return new FindResultResponse<WorkspaceResponse>();
    }

    return new FindResultResponse<WorkspaceResponse>()
    {
      Body  = dbWorkspaces.Select(w => _responseMapper.Map(w)).ToList(),
      TotalCount = totalCount
    };
  }
}
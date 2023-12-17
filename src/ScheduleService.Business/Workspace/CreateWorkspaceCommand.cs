﻿using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Workspace.Interfaces;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Workspace;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Workspace;

public class CreateWorkspaceCommand : ICreateWorkspaceCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(CreateWorkspaceRequest request)
    {
        throw new NotImplementedException();
    }
}
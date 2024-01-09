﻿using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group;

public class DeleteGroupCommand : IDeleteGroupCommand
{
  public Task<OperationResultResponse<bool>> ExecuteAsync(Guid id)
  {
    throw new System.NotImplementedException();
  }
}

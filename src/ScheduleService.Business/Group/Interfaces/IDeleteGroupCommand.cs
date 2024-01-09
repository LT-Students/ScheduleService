﻿using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Group.Interfaces;

[AutoInject]
public interface IDeleteGroupCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(Guid id);
}

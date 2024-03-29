﻿using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Task.Interfaces;

[AutoInject]
public interface IRemoveTaskCommand
{
  Task<OperationResultResponse<bool>> ExecuteAsync(Guid id);
}


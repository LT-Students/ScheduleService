﻿using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.Kernel.Responses;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;

[AutoInject]
public interface IDeleteCategoryCommand
{
  Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id);
}

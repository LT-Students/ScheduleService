﻿using LT.DigitalOffice.Kernel.Responses;
using LT.DigitalOffice.ScheduleService.Business.Category.Interfaces;
using System;
using System.Threading.Tasks;

namespace LT.DigitalOffice.ScheduleService.Business.Category;

public class GetCategoryCommand : IGetCategoryCommand
{
    public Task<OperationResultResponse<Guid?>> ExecuteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
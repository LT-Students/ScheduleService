﻿using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;

namespace LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;

[AutoInject]
public interface ICreateCategoryRequestValidator : IValidator<CreateCategoryRequest>
{
}

using FluentValidation;
using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using System;

namespace LT.DigitalOffice.ScheduleService.Validation.Category.Interfaces;

[AutoInject]
public  interface IUpdateCategoryRequestValidator : IValidator<(Guid, Guid, EditCategoryRequest)>
{
}

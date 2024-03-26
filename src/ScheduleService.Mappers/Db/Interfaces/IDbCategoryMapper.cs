using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Requests.Category;
using System;

namespace LT.DigitalOffice.ScheduleService.Mappers.Db.Interfaces;

[AutoInject]
public interface IDbCategoryMapper
{
  DbCategory Map(CreateCategoryRequest request, Guid userId);
}

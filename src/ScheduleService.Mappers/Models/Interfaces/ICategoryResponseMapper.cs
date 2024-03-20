﻿using LT.DigitalOffice.Kernel.Attributes;
using LT.DigitalOffice.ScheduleService.Models.Db;
using LT.DigitalOffice.ScheduleService.Models.Dto.Responses;

namespace LT.DigitalOffice.ScheduleService.Mappers.Models.Interfaces;

[AutoInject]
public interface ICategoryResponseMapper
{
  CategoryResponse Map(DbCategory category);
}

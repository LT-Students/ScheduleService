using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LT.DigitalOffice.ScheduleService.Models.Dto.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum CategoryColor
{
  Color01,
  Color02,
  Color03,
  Color04,
  Color05,
  Color06,
  Color07,
  Color08,
  Color09,
  Color10,
  Color11,
  Color12,
}
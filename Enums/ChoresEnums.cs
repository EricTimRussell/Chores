using System.Text.Json.Serialization;

namespace Chores.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreType
{
  Vaccum,
  Dishes,
  MowLawn,
  CleanBathroom,
  CleanRoom,
  MakeBed
}

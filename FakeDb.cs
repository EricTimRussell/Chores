using Chores.Enums;

namespace Chores.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Sally", 1400, false, ChoreType.Vaccum),
    new Chore("Trent", 1600, false, ChoreType.CleanBathroom),
    new Chore("Milo", 1100, false, ChoreType.CleanRoom),
    new Chore("Brenda", 0800, false, ChoreType.Dishes),
    new Chore("Eric", 0700, true, ChoreType.MakeBed),
    new Chore("Todd", 1800, false, ChoreType.MowLawn),
    new Chore("Jim", 1400, true, ChoreType.Vaccum)
  };
}
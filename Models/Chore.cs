using System.ComponentModel.DataAnnotations;
using Chores.Enums;
namespace Chores.Models;

public class Chore
{
  public string Id { get; private set; }
  // Assigned to name
  public string Name { get; private set; }
  public int Time { get; private set; }
  public bool ChoreDone { get; private set; }
  public ChoreType Type { get; private set; }

  public void UpdateChore(ChoreUpdateModel chore)
  {
    Name = chore.Name ?? Name;
    Time = chore.Time ?? Time;
    if (chore.ChoreDone != null)
    {
      ChoreDone = (bool)chore.ChoreDone;
    }
  }


  public Chore() { }

  public Chore(string name, int time, bool choreDone, ChoreType type)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Time = time;
    ChoreDone = choreDone;
    Type = type;
  }

}

public class ChoreUpdateModel
{
  [MinLength(3)]
  public string Name { get; set; }
  public int? Time { get; set; }
  public bool? ChoreDone { get; set; }
  public ChoreType? Type { get; set; }
}

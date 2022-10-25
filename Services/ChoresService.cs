namespace Chores.Services;

public class ChoresService
{
  private readonly FakeDb _db;

  public List<Chore> GetChores()
  {
    // Gets more complicated later
    return _db.Chores;
  }

  internal Chore AddChore(Chore choreData)
  {
    // More complex later
    _db.Chores.Add(choreData);
    return choreData;
  }

  internal object GetChore(string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    return chore;
  }
  internal object DeleteChore(string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    _db.Chores.Remove(chore);
    return chore;
  }
  internal object EditChore(ChoreUpdateModel choreData, string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    chore.UpdateChore(choreData);
    return chore;
  }
  public ChoresService(FakeDb db)
  {
    _db = db;
  }

}
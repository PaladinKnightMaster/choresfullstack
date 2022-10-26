namespace choreApi.Services;

public class ChoresService
{
  private readonly FakeDb _db;

  public List<Chore> GetChores()
  {
    return _db.Chores;
  }
  public Chore GetChoreById(string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Your id doesnt apply to any chores");
    }
    return chore;
  }

  public Chore PostChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;
  }

  public Chore DeleteChore(string id)
  {
    var deletedChore = this.GetChoreById(id);
    _db.Chores.Remove(deletedChore);
    return deletedChore;
  }
  public Chore EditChore(string id)
  {
    var selectedChore = this.GetChoreById(id);
    // _db.Chores.FindIndex(selectedChore);

    return null;
  }

  public ChoresService(FakeDb db)
  {
    _db = db;
  }


}
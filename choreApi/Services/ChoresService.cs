namespace choreApi.Services;

public class ChoresService
{
  private readonly ChoreRepository _choreRepo;
  public ChoresService(ChoreRepository choreRepository)
  {
    _choreRepo = choreRepository;
  }


  public List<Chore> GetChores()
  {
    return _choreRepo.GetChores();
  }
  public Chore GetChoreById(string id)
  {
    var chore = _choreRepo.GetChoreById(id);
    if (chore == null)
    {
      throw new Exception("Your id doesnt apply to any chores");
    }
    return chore;
  }

  public Chore PostChore(Chore choreData)
  {
    var chore = _choreRepo.PostChore(choreData);
    return chore;
  }

  public Chore DeleteChore(string id)
  {
    var deletedChore = this.GetChoreById(id);
    _choreRepo.DeleteChore(id);
    return deletedChore;
  }
  public Chore EditChore(string id, Chore choreData)
  {
    var NewChore = _choreRepo.EditChore(choreData);
    return NewChore;
  }

}
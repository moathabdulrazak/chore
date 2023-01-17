
namespace chore.Services;

public class ChoresService
{

  private readonly ChoreRepository _repo;


  public ChoresService(ChoreRepository repo)
  {
    _repo = repo;
  }

  internal Chore create(Chore choreData)
  {
    Chore newChore = _repo.create(choreData);
    return newChore;
  }

  internal List<Chore> Get()
  {
    List<Chore> chores = _repo.Get();
    return chores;
  }

  internal string Remove(int id)
  {
    string message = _repo.Remove(id);
    return message;
  }
}



namespace chore.Repositories;

public class ChoreRepository
{
  private List<Chore> choreDb;






  public ChoreRepository()
  {
    this.choreDb = new List<Chore>(){
        new Chore(1, "brush teeth", "i must bursh teeth"),
        new Chore(2, "do sum", "do sum mo"),
        new Chore(3, "doing something", "do sumthing mo"),
        new Chore(4, "doing that thing", "do sumthing more thing"),
        new Chore(5, "i want do thing", "we do thing"),
      };
  }

  internal Chore create(Chore choreData)
  {
    choreData.Id = choreDb[choreDb.Count - 1].Id + 1;
    choreDb.Add(choreData);
    return choreData;
  }

  internal List<Chore> Get()
  {
    return choreDb;
  }

  internal string Remove(int id)
  {
    Chore choreToRemove = choreDb.Find(c => c.Id == id);

    bool result = choreDb.Remove(choreToRemove);
    if (result)
    {
      return $"{choreToRemove.Name} was earsed";
    }
    return "no chore";
  }
}

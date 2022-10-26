namespace choreApi.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
new Chore ("Dishes", 5, false),
new Chore ("Trash", 3, true),
new Chore ("Lawn", 7, false),
new Chore ("Dog Walk", 4, true),
new Chore ("Clean", 4, true),

};
}
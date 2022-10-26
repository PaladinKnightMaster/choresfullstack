namespace choreApi.Models;

public class Chore
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public int Value { get; private set; }
  public bool IsCompleted { get; private set; }


  public Chore(string name, int value, bool isCompleted)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Value = value;
    IsCompleted = isCompleted;

  }
}
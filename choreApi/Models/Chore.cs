namespace choreApi.Models;

public class Chore
{
  public string Id { get; set; }
  public string Name { get; set; }
  public int Value { get; set; }
  public bool IsCompleted { get; set; }
  public string CreatorId { get; set; }

  public Chore(string name, int value, bool isCompleted, string creatorId)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Value = value;
    IsCompleted = isCompleted;
    CreatorId = creatorId;
  }
}
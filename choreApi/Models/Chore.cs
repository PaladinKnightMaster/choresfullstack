namespace choreApi.Models;

public class Chore
{
  public string Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string Name { get; set; }
  public int Value { get; set; }
  public bool IsCompleted { get; set; }
  public string CreatorId { get; set; }


}
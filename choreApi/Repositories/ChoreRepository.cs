namespace choreApi.Repositories;

public class ChoreRepository
{

  private readonly IDbConnection _db;

  public ChoreRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Chore> GetChores()
  {
    var sql = "SELECT * FROM chores";
    return _db.Query<Chore>(sql).ToList();
  }

  public Chore GetChoreById(string id)
  {
    var sql = "SELECT * FROM chores WHERE id = @id";
    return _db.QuerySingle<Chore>(sql, new { id });
  }

  public Chore PostChore(Chore choreData)
  {
    // TODO finish these inserts from model
    var sql = @"INSERT INTO cars
    ( id, name, value, isCompleted, creatorId)
      VALUES
    ( @Id, @Name, @Value, @IsCompleted, @CreatorId);
      SELECT LAST_INSERT_ID();
    ";
    choreData.Id = _db.ExecuteScalar<string>(sql, choreData);
    return choreData;
  }

  public Chore DeleteChore(string id)
  {
    var chore = GetChoreById(id);
    var sql = "DELETE FROM chores WHERE id = @id;";
    _db.Execute(sql, new { id });
    return chore;
  }

  public Chore EditChore(Chore choreData)
  {
    throw new NotImplementedException();
  }
}


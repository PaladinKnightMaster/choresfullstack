namespace choreApi.Repositories;

public class ChoreRepository
{
  public ChoreRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;


  internal List<Chore> GetChores()
  {
    var sql = "SELECT * FROM chores";
    return _db.Query<Chore>(sql).ToList();
  }

  internal Chore GetChoreById(string id)
  {
    var sql = "SELECT * FROM chores WHERE id = @id";
    return _db.QuerySingle<Chore>(sql, new { id });
  }

  internal Chore PostChore(Chore choreData)
  {
    // TODO finish these inserts from model
    var sql = @"INSERT INTO cars
    ()
      VALUES
    ();
      SELECT LAST_INSERT_ID();
    ";
    choreData.Id = _db.ExecuteScalar<string>(sql, choreData);
    return choreData;
  }

  internal Chore DeleteChore(string id)
  {
    throw new NotImplementedException();
  }

  internal Chore EditChore(Chore choreData)
  {
    throw new NotImplementedException();
  }
}


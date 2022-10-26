namespace choreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _cs;

  [HttpGet]
  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      var chores = _cs.GetChores();
      return Ok(chores);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Chore> GetChoreById(string id)
  {
    try
    {
      var chore = _cs.GetChoreById(id);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> PostChore([FromBody] Chore choreData)
  {
    try
    {
      var NewChore = _cs.PostChore(choreData);
      return Ok(NewChore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<Chore> DeleteChore(string id)
  {
    try
    {
      var deletedChore = _cs.DeleteChore(id);
      return deletedChore;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Chore> EditChore(string id)
  {
    try
    {
      var editedChore = _cs.EditChore(id);
      return editedChore;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  public ChoresController(ChoresService cs)
  {
    _cs = cs;
  }
}

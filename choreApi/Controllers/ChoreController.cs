namespace choreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _cs;
  public ChoresController(ChoresService cs, Auth0Provider auth0Provider)
  {
    _cs = cs;
    _auth0Provider = auth0Provider;
  }
  private readonly Auth0Provider _auth0Provider;


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
  public async Task<ActionResult<Chore>> PostChore([FromBody] Chore choreData)
  {
    try
    {
      var creatorInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      choreData.CreatorId = creatorInfo?.Id;
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
  public ActionResult<Chore> EditChore(string id, [FromBody] Chore choreData)
  {
    try
    {
      var editedChore = _cs.EditChore(id, choreData);
      return editedChore;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }

}

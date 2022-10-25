namespace Chores.Controllers;

[ApiController]
// The new Super
[Route("api/[controller]")]
// The new extends base controller replaced with colon
public class ChoresController : ControllerBase
{
  private readonly ChoresService _cs;
  // The new get requset
  [HttpGet]
  public ActionResult<List<string>> Get()
  {
    try
    {
      var chores = _cs.GetChores();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  // The new post request
  [HttpPost]
  public ActionResult<Chore> Create([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _cs.AddChore(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Chore> GetChore(string id)
  {
    try
    {
      var chore = _cs.GetChore(id);
      return Ok(chore);
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
      var chore = _cs.DeleteChore(id);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Chore> EditChore([FromBody] ChoreUpdateModel choreData, string id)
  {
    try
    {
      var chore = _cs.EditChore(choreData, id);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  public ChoresController(ChoresService cs)
  {
    _cs = cs;
  }

}
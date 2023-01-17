

namespace chore.Controllers;

[ApiController]
[Route("api/chores")]


public class ChoresController : ControllerBase
{

  private readonly ChoresService _choresService;



  public ChoresController(ChoresService choresService)
  {
    this._choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      List<Chore> chores = _choresService.Get();
      return Ok(chores);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }



  [HttpPost]

  public ActionResult<Chore> create([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.create(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }


  [HttpDelete("{id}")]
  public ActionResult<string> Remove(int id)
  {
    try
    {
      string Message = _choresService.Remove(id);
      return Ok(Message);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }
}



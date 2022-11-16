
namespace ApiBasics.Controllers;
public class StatusController : ControllerBase
{
    // GET /status
    [HttpGet("/status")]
    public ActionResult GetTheStatus()
    {
        return Ok("Everything looks good Jeff Was Here Nothing? Now?");
    }
}

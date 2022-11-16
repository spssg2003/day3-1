namespace CoursesApi.Controllers;

public class DemoController : ControllerBase
{
    private readonly ILogger<DemoController> _logger;

    public DemoController(ILogger<DemoController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/demo")]
    public async Task<ActionResult> GetTheGood(CancellationToken token)
    {
        _logger.LogInformation("About to do some serious work");
        // TODO: Serious Async Work Here.
       
            await Task.Delay(5000, token);
       
        _logger.LogInformation("Done doing  some serious work");
        return Ok("All Done!");
    }
}

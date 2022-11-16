namespace ApiBasics.Controllers;

public class DemoController : ControllerBase
{
    // Anything? this is it!!!
    // The Uri and route parameters, query strings etc.
    // - Query String
    // "Collections"
    // GET /employees?department=SALES

    [HttpGet("/employees")]
    public ActionResult GetEmployees([FromQuery] string department = "All")
    {
        
        return Ok($"{department} employees!");
    }
    // "Documents"
    // /employees/89 - 200 | 404
    [HttpGet("/employees/{id:int}")]
    public ActionResult GetEmployee(int id)
    {
        if (id % 2 == 0)
        {
            var response = new EmployeeDetailsResponse { 
                Id = id,
                FirstName = "Bob", 
                LastName = "Smith", 
                EmailAddress = "bob@aol.com" };
            return Ok(response);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost("/employees")]
    public ActionResult HireAnEmployee([FromBody] EmployeeCreateRequest request)
    {
        return Ok(request);
    }

     // an addition
    [HttpGet("/employees/{id:int}/manager")]
    public ActionResult GetEmployeeManager(int id) {
        return Ok("Michael");
    }
    // GET /employees/bob-smith (Subordinate Resource)


    // GET /department/{id}/employees
    // GET /department/sales/employees


    // The headers (rare, but useful)

    [HttpGet("/whoami")]
    public ActionResult GetUserAgentString([FromHeader(Name ="User-Agent")] string userAgent)
    {
        return Ok("You are running " + userAgent);
    }

    // An entity

}


using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace CoursesApi.Controllers;

public class CoursesController : ControllerBase
{

    private readonly CourseCatalog _catalog;
    private readonly IProvideOfferings _offerings;

    public CoursesController(CourseCatalog catalog, IProvideOfferings offerings)
    {
        _catalog = catalog;
        _offerings = offerings;
    }

    //[HttpGet("/v2/courses/{id:int}")]
    //public async Task<ActionResult> GetCoursesById2(int id, [FromServices] OfferingsCatalogApiCall service)
    //{
    //    return Ok();
    //}

    [HttpGet("/courses/{id:int}/offerings")]
    [ResponseCache(Duration =3600, Location = ResponseCacheLocation.Any)]
    public async Task<ActionResult> GetOfferingsForCourse(int id)
    {
        // TODO talk about a 404 here.
        // check to see if that course exists, if it doesn, return a 404.
        var data = await _offerings.GetOfferingsForCourse(id);
        return Ok(new { Offerings= data });
    }

    [HttpGet("/courses/{id:int}")]
    public async Task<ActionResult<CourseItemDetailsResponse>> GetCourseById(int id, CancellationToken token)
    {
        CourseItemDetailsResponse? response = await _catalog.GetCourseByIdAsync(id, token);
        return response is CourseItemDetailsResponse data ? Ok(data) : NotFound();
        //if (response == null)
        //{
        //    return NotFound();
        //} else
        //{
        //    return Ok(response);
        //}
    }

    [HttpGet("/courses")]
    public async  Task<ActionResult<CoursesResponseModel>> GetCoursesAsync(CancellationToken token)
    {
        CoursesResponseModel response = await _catalog.GetFullCatalogAsync(token);

       
        return Ok(response);
    }
}

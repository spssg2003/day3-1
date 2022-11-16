using Microsoft.EntityFrameworkCore;

namespace CoursesApi.Domain;

public class CourseCatalog
{
    private readonly CoursesDataContext _context;
 

    public CourseCatalog(CoursesDataContext context)
    {
        _context = context;

    }

    public async Task<CoursesResponseModel> GetFullCatalogAsync(CancellationToken token)
    {
        var courses = await _context.Courses.Where(c => c.Retired == false)
            .Select(c => new CourseItemResponse
            {
                Id = c.Id.ToString(),
                Title = c.Title,
                Category = c.Category
            }).ToListAsync(token);
     
        return new CoursesResponseModel
        {
            Courses = courses,
            NumberOfBackendCourses = courses.Count(c => c.Category == CategoryType.Backend),
            NumberOfFrontendCourses = courses.Count(c => c.Category == CategoryType.Frontend)
        };
    }

    public async Task<CourseItemDetailsResponse?> GetCourseByIdAsync(int id, CancellationToken token)
    {

        var response = await _context.Courses.Where(c => c.Id == id && c.Retired == false)
            .Select(c => new CourseItemDetailsResponse
            {
                Id = c.Id.ToString(),
                Title = c.Title,
                Category = c.Category,
                Description = c.Description,
              
            }).SingleOrDefaultAsync(token);

       
        return response;
    }
}

namespace CoursesApi.Models;

public record CoursesResponseModel
{
    public int NumberOfBackendCourses { get; init; }
    public int NumberOfFrontendCourses { get; init; }

    public List<CourseItemResponse> Courses { get; init; } = new();

}

public record CourseItemResponse
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public CategoryType Category { get; set; }


} 

public record CourseItemDetailsResponse
{
    public string Id { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public CategoryType Category { get; init; }
    public string Description { get; init; } = string.Empty;

   
}
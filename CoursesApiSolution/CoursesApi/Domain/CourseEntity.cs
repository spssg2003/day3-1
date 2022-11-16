using System.Text.Json.Serialization;

namespace CoursesApi.Domain;

public class CourseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
   
    public CategoryType Category { get; set; }
    public int NumberOfDays { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool Retired { get; set; }
}

public enum CategoryType {  Frontend, Backend }
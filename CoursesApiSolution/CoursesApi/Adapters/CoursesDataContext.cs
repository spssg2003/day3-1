
using Microsoft.EntityFrameworkCore;

namespace CoursesApi.Adapters;

public class CoursesDataContext : DbContext
{
	public CoursesDataContext(DbContextOptions<CoursesDataContext> options) : base(options)
	{

	}
	public DbSet<CourseEntity> Courses { get; set; } = null!;


}

namespace CoursesApi.Domain;

public interface IProvideOfferings
{
    Task<List<DateTime>> GetOfferingsForCourse(int courseId);
}
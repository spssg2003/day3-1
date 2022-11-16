namespace OfferingsAPI.Services;

public interface IProvideOfferings
{
    Task<List<DateTime>> GetOfferingsForCourse(int courseId);
}
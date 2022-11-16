namespace CoursesApi.Domain;

public class OfferingsCatalogApiCall : IProvideOfferings
{
    private readonly OfferingsApiAdapter _adapter;

    public OfferingsCatalogApiCall(OfferingsApiAdapter adapter)
    {
        _adapter = adapter;
    }

    public async Task<List<DateTime>> GetOfferingsForCourse(int courseId)
    {
       var response = await _adapter.GetOfferingsForCourseAsync(courseId);
        return response!.Data;
    }
}

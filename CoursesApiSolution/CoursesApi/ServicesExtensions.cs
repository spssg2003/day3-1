namespace CoursesApi;

public static class ServicesExtensions
{
    public static void AddCoursesServices(this IServiceCollection services)
    {
        services.AddTransient<IProvideOfferings, OfferingsCatalogApiCall>();
        services.AddTransient<CourseCatalog>();
        // etc. etc.
    }
}

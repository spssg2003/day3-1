using OfferingsAPI.Services;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProvideOfferings, OfferingsCatalog>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/{id:int}", async (int id, IProvideOfferings offeringsService) =>
{
    var offerings = await offeringsService.GetOfferingsForCourse(id);
    return Results.Ok(new { data = offerings });
});


app.Run();


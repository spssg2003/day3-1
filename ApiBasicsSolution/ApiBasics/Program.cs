var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Above this line is configuring the services used in your application (.net core 3.1 ConfigureServices)
var app = builder.Build();
// After this line is configuring the HTTP pipeline - how individual requests and responses (.net Core 3.1 would be in the Configure)

// are handled.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // generate the open api spec
    app.UseSwaggerUI(); // use the swagger ui web page thing to show it.
}

app.UseAuthorization();

app.MapControllers();
Console.WriteLine("Before The Run");
app.Run(); // this is blocking
Console.WriteLine("After the Run");
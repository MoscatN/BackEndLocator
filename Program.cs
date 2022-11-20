using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LocatorBackEnd.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LocatorBackEndContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocatorBackEndContext") ?? throw new InvalidOperationException("Connection string 'LocatorBackEndContext' not found.")));

// Add services to the container.

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    //Se crea una lambda expression para establecer una nueva politica
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        //Dos maneras de establecer donde se permitira el CORS, si no funciona una probar con la otra.
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
        //builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();

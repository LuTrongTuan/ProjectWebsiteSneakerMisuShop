using BE_SneakrerMisuShop.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("__cors", policy =>
    {
        policy.AllowAnyHeader()
          .WithMethods("POST", "GET", "PUT", "PATCH", "DELETE")
          .AllowCredentials()
          .SetIsOriginAllowed(e => new Uri(e).Host == "localhost");
    });
});

builder.Services.AddDbContext<MisuContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SneakerMisuShop"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseCors("__cors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

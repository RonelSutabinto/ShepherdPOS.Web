using ShepherdPOS.Api.Data;
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.Repositories.Contracts;
using ShepherdPOS.Api.Repositories;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<ShepherdPosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
//builder.Services.AddScoped<IPosCartRepository, IPosCartRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
    policy.WithOrigins("http://localhost:7166", "https://localhost:7166")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


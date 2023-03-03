
using AutoMapper;
using Microsoft.EntityFrameworkCore;
//using ShepherdPOS.Api.Repositories.Interface;
//using ShepherdPOS.Api.Repositories;
using Microsoft.Net.Http.Headers;
using System;

using ShepherdPOS.Api.Entities;
using ShepherdPOS.Api.Data;
using ShepherdPOS.Api.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<ShepherdPosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(typeof(ShepherdPOSMapperProfile));


builder.Services.AddTransient<StockController>();
//builder.Services.AddScoped<IProductRepository, ProductRepository>();
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

//app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();



app.MapRazorPages();

app.MapControllers();

app.Run();


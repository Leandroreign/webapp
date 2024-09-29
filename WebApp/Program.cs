
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using System;
using static System.Net.Mime.MediaTypeNames;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WebAppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
//builder.Services.AddCustomDbContext<WebAppContext>(builder.Configuration);
//builder.Services.AddCustomIdentity<User, Roles, WebAppContext, Guid>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}");

app.Run();

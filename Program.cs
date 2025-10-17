using Microsoft.EntityFrameworkCore;
using Day09LabCF.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var connectString = builder.Configuration.GetConnectionString("Day09LabConnection");
builder.Services.AddDbContext<Day09LabCFContext>(options => options.UseSqlServer(connectString));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

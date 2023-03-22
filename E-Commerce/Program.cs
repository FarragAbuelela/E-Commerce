using E_Commerce.BL;
using E_Commerce.BL.Interfaces;
using E_Commerce.BL.Models;
using E_Commerce.DL;
using E_Commerce.DL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
        ));

//builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
var app = builder.Build();



//builder.Services.AddSingleton(typeof(IBaseRepository<Category>), typeof(BaseRepository<Category>));

//builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));





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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

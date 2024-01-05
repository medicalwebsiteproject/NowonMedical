using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NowonMedical.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<NowonMedicalContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql-Linux-Docker")));

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}*/

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Index}");

app.MapControllerRoute(
    name: "intro",
    pattern: "{controller=Intro}");

app.MapControllerRoute(
    name: "clinic",
    pattern: "{controller=Clinic}");

app.MapControllerRoute(
    name: "community",
    pattern: "{controller=Community}/{action=Index}/{boardType=Board:regex((News|Review|Notice))}");


app.Run();

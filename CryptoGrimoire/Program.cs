using Microsoft.EntityFrameworkCore;
using CryptoGrimoire.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddWebOptimizer(pipeline =>
{
    pipeline.AddScssBundle("/css/site.min.css", "lib/bootstrap/dist/css/bootstrap.min.css", "css/site.scss");
    pipeline.AddJavaScriptBundle("/js/site.min.js", "lib/jquery/dist/jquery.min.js", "js/site.js", "wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseWebOptimizer();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

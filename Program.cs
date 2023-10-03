using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CyberStore.Data;
using CyberStore.Database;
using CyberStore.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationRepository>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("ApplicationConnection")));

builder.Services.AddDbContext<IdentityRepository>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("IdentityConnection")));

builder.Services
    .AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<IdentityRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Services.CreateRoles().Wait();

app.Services.CreateUsers().Wait();
app.Services.CreateProducts();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();

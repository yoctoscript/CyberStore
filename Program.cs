using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CyberStore.Data;
using CyberStore.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationRepository>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<IdentityRepository>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<IdentityRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Services.CreateRoles().Wait();

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

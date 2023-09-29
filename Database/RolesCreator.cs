using System.Configuration;
using CyberStore.Data;
using Microsoft.AspNetCore.Identity;

namespace CyberStore.Database;

public static class RolesCreator
{
    private static string[] Roles {get;} = {"Administrator", "Moderator", "Member"};

    public static async Task CreateRoles(this IServiceProvider services)
    {
        var scope = services.CreateScope();
        var roleManager = (RoleManager<IdentityRole>)scope.ServiceProvider.GetService(typeof(RoleManager<IdentityRole>))!;
        var userManager = (UserManager<IdentityUser>)scope.ServiceProvider.GetService(typeof(UserManager<IdentityUser>))!;
        var configuration = services.GetRequiredService<IConfiguration>();
        IdentityResult roleResult;

        foreach (var roleName in Roles)
        {
            var roleExists = await roleManager.RoleExistsAsync(roleName);
            if(!roleExists)
            {
                var role = new IdentityRole(roleName);
                roleResult = await roleManager.CreateAsync(role);
            }
        }

        var superUser = new IdentityUser
        {
            UserName = configuration["Administrator:UserName"],
            Email = configuration["Administrator:Email"]
        };

        var password = configuration["Administrator:Password"];
        var _superUser = await userManager.FindByEmailAsync(configuration["Administrator:Email"]!);

        if (_superUser is null)
        {
            var createSuperUser = await userManager.CreateAsync(superUser, password!);
            if (createSuperUser.Succeeded)
            {
                await userManager.AddToRoleAsync(superUser, "Administrator");
            }
        }
    }
}
using CyberStore.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CyberStore.Database;

public static class UsersCreator
{
    
    public static async Task CreateUsers(this IServiceProvider services)
    {
        var scope = services.CreateScope();
        var userManager = (UserManager<IdentityUser>)scope.ServiceProvider.GetService(typeof(UserManager<IdentityUser>))!;
    
        var Users = new List<UserInfo>()
        {
            new UserInfo() {UserName = "Yumi", Email = "yumi@mail.com", Password = "Yumi123;", Roles = new List<string>(){"Member"}},
            new UserInfo() {UserName = "Ulrich", Email = "ulrich@mail.com", Password = "Ulrich123;", Roles = new List<string>(){"Member", "Moderator"}},
            new UserInfo() {UserName = "Della", Email = "della@mail.com", Password = "Della123;", Roles = new List<string>(){"Member"}},
            new UserInfo() {UserName = "William", Email = "william@mail.com", Password = "William123;", Roles = new List<string>(){"Member"}},
            new UserInfo() {UserName = "Aelita", Email = "aelita@mail.com", Password = "Aelita123;", Roles = new List<string>(){"Member"}},
            new UserInfo() {UserName = "Jeremie", Email = "jeremie@gmail.com", Password = "Jeremie123;", Roles = new List<string>(){"Member", "Moderator", "Administrator"}}
        };

        foreach (var user in Users)
        {
            var identityUser = new IdentityUser() {UserName = user.UserName, Email = user.Email};
            var _u = await userManager.FindByEmailAsync(user.Email!);
            if (_u is null)
            {
                var createUser = await userManager.CreateAsync(identityUser, user.Password!);
                if (createUser.Succeeded)
                {
                    await userManager.AddToRolesAsync(identityUser, user.Roles!);
                }
            }
        }
        scope.Dispose();
    }
}
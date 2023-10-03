using CyberStore.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CyberStore.Database;

public static class UsersCreator
{
    
    public static List<UserInfo> Users = new()
    {
        new UserInfo() {UserName = "Moderator", Email = "moderator@mail.com", Password = "Sudo123;", TwoFactorEnabled = true, PhoneNumber = "", Roles = new List<string>(){"Moderator"}},
        new UserInfo() {UserName = "SebastianMorgans", Email = "SebastianMorgans@jourrapide.com", Password = "ahDahxee2ch;", PhoneNumber = "559-527-5804", TwoFactorEnabled = true, Roles = new List<string>(){"Member"}},
        new UserInfo() {UserName = "SummerMelbourne", Email = "SummerMelbourne@rhyta.com", Password = "oop4oaB9ie;", PhoneNumber = "512-308-2034", TwoFactorEnabled = false, Roles = new List<string>(){"Member"}},
        new UserInfo() {UserName = "AnnaDarker", Email = "AnnaDarker@dayrep.com", Password = "sael7fi6Ie!", PhoneNumber = "507-426-6122", TwoFactorEnabled = true, Roles = new List<string>(){"Member"}},
        new UserInfo() {UserName = "AvaCullen", Email = "AvaCullen@teleworm.us", Password = "ech8euVeo!", PhoneNumber = "201-547-8133", TwoFactorEnabled = true, Roles = new List<string>(){"Member"}},
        new UserInfo() {UserName = "OliviaNilsen", Email = "oliviaNilsen@teleworm.us", Password = "ahch3Too!", PhoneNumber = "302-666-7735", TwoFactorEnabled = true, Roles = new List<string>(){"Member"}},
        new UserInfo() {UserName = "ChristopherEstell", Email = "ChristopherEstell@dayrep.com", Password = "ahZ8FeYai3!", PhoneNumber = "985-657-0468", TwoFactorEnabled = true, Roles = new List<string>(){"Member"}}
    };
    public static async Task CreateUsers(this IServiceProvider services)
    {
        var scope = services.CreateScope();
        var userManager = (UserManager<IdentityUser>)scope.ServiceProvider.GetService(typeof(UserManager<IdentityUser>))!;
    
        

        foreach (var user in Users)
        {
            var identityUser = new IdentityUser() {UserName = user.UserName, Email = user.Email, TwoFactorEnabled = (bool)user.TwoFactorEnabled, PhoneNumber = user.PhoneNumber};
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
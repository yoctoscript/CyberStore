using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CyberStore.ViewModels;
using System.Text.Json;

namespace CyberStore.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> logger;
    private readonly UserManager<IdentityUser> userManager;
    public UserController(ILogger<UserController> logger, UserManager<IdentityUser> userManager)
    {
        this.logger = logger;
        this.userManager = userManager;
    }
    
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Index()
    {
        IList<UserInfo> UsersInfo = new List<UserInfo>();
        foreach (var user in userManager.Users)
        {
            var userInfo = new UserInfo();
            userInfo.Id = user.Id;
            userInfo.Email = user.Email!;
            userInfo.UserName = user.UserName!;
            userInfo.Roles = await userManager.GetRolesAsync(user);
            UsersInfo.Add(userInfo);
        }
        return View(UsersInfo);
    }
    
    [Authorize(Roles = "Administrator")]
    public IActionResult Create()
    {
        return View("Create");
    }

    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Read(string? id)
    {
        if (id is not null)
        {
            IdentityUser? user = await userManager.FindByIdAsync(id);
            if (user is not null)
            {
                var userInfo = new UserInfo()
                {
                    Id = user.Id,
                    UserName = user.UserName!,
                    Email = user.Email!,
                    PhoneNumber = user.PhoneNumber!,
                    TwoFactorEnabled = user.TwoFactorEnabled
                };
                return View("Read", userInfo);
            }
        }
        return NotFound();
    }

    [Authorize(Roles = "Administrator")]
    public IActionResult Update(string? id)
    {
        return View("Update", id);
    }

    [Authorize(Roles = "Administrator")]
    public IActionResult Delete(string? id)
    {
        return View("Delete", id);
    }
}
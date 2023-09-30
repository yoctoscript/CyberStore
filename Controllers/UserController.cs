using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CyberStore.Models;
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
        return View();
    }

    [Authorize(Roles = "Administrator")]
    public IActionResult Read()
    {
        return View();
    }

    [Authorize(Roles = "Administrator")]
    public IActionResult Update(int id)
    {
        return View();
    }

    [Authorize(Roles = "Administrator")]
    public IActionResult Delete(int id)
    {
        return View();
    }
}
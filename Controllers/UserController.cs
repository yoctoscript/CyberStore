using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CyberStore.ViewModels;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

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
            userInfo.Roles = (List<string>)await userManager.GetRolesAsync(user);
            UsersInfo.Add(userInfo);
        }
        return View(UsersInfo);
    }
    
    [HttpGet]
    [Authorize(Roles = "Administrator")]
    public IActionResult Create()
    {
        return View("Create");
    }

    [HttpPost]
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Create(UserInfo userInfo)
    {
        if (ModelState.IsValid)
        {
            var identityUser = new IdentityUser() {UserName = userInfo.UserName, Email = userInfo.Email, PhoneNumber = userInfo.PhoneNumber, TwoFactorEnabled = (bool)userInfo.TwoFactorEnabled};
            var _u = await userManager.FindByNameAsync(userInfo.UserName);
            if (_u is not null)
            {
                ModelState.AddModelError("Username","Username already exists in the database. Please select a different one.");
                return View("Create", userInfo);
            }
            if (_u is null)
            {
                var createdUser = await userManager.CreateAsync(identityUser, userInfo.Password);
                if (createdUser.Succeeded)
                {
                    await userManager.AddToRolesAsync(identityUser, userInfo.Roles);
                    return RedirectToAction("Index");
                }
                else
                {
                    var passwordErrors = string.Empty;
                    foreach (var error in createdUser.Errors)
                    {
                        if (error.Code.StartsWith("Password"))
                        {
                            passwordErrors += error.Description + " ";
                        }
                    }
                    ModelState.AddModelError("Password", passwordErrors);
                    return View("Create", userInfo);
                }
            }
        }
        return View("Create", userInfo);
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

    [HttpGet]
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Update(string? id)
    {
        var identityUser = await userManager.FindByIdAsync(id);
        if (identityUser is not null)
        {
            var userInfo = new UserInfo()
            {
                Id = identityUser.Id,
                UserName = identityUser.UserName,
                Email = identityUser.Email,
                PhoneNumber = identityUser.PhoneNumber,
                TwoFactorEnabled = identityUser.TwoFactorEnabled,
                Roles = (List<string>)await userManager.GetRolesAsync(identityUser)

            };
            return View("Update", userInfo);
        }
        return NotFound();
    }

    [HttpPost]
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Update(UserInfo userInfo)
    {
        if (ModelState.IsValid)
        {
            var identityUser = await userManager.FindByIdAsync(userInfo.Id);
            if (identityUser is not null)
            {
                identityUser.UserName = userInfo.UserName;
                identityUser.Email = userInfo.Email;
                identityUser.PhoneNumber = userInfo.PhoneNumber;
                identityUser.TwoFactorEnabled = (bool)userInfo.TwoFactorEnabled;
                await userManager.UpdateAsync(identityUser);
                
                List<string> currentRoles = (List<string>)await userManager.GetRolesAsync(identityUser);
                await userManager.RemoveFromRolesAsync(identityUser, currentRoles);
                await userManager.AddToRolesAsync(identityUser, userInfo.Roles);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        return NotFound();
    }
    [HttpGet]
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Delete(string? id)
    {
        var identityUser = await userManager.FindByIdAsync(id);
        if (identityUser is not null)
        {
            await userManager.DeleteAsync(identityUser);
            return RedirectToAction("Index");
        }
        return NotFound();
    }
}
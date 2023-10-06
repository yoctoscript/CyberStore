using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CyberStore.Models;
using CyberStore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;

namespace CyberStore.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationRepository applicationRepository;

    public HomeController(ApplicationRepository applicationRepository)
    {
        this.applicationRepository = applicationRepository;
    }

    public IActionResult Index(int id=0)
    {
        var cartId = HttpContext.Request.Cookies["CartId"];
        if (cartId is null)
        {
            cartId = Guid.NewGuid().ToString();
            HttpContext.Response.Cookies.Append("CartId", cartId);
        }
        ViewData["CartId"] = cartId;


        var itemsPerPage = 9;
        var query = applicationRepository.Products.AsNoTracking().OrderBy(p => p.Id).Skip(id * itemsPerPage).Take(itemsPerPage);
        IEnumerable<Product> products = query.ToList();
        var count = applicationRepository.Products.Count();
        var pages = ((count % itemsPerPage) == 0) ? (count/itemsPerPage) : ((count / itemsPerPage) + 1); 
        ViewData["Pages"] = pages;
        ViewData["Id"] = id;

        ViewData["Total"] = 50.5f;
        ViewData["Items"] = 6;
        return View("Index", products);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

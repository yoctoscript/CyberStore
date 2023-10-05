using Microsoft.AspNetCore.Mvc;
using CyberStore.Models;
using Microsoft.AspNetCore.Authorization;
using CyberStore.Data;
namespace CyberStore.Controllers;

public class CartController : Controller
{
    public readonly ApplicationRepository applicationRepository;
    public CartController(ApplicationRepository applicationRepository)
    {
        this.applicationRepository = applicationRepository;
    }

    public IActionResult Show()
    {
        var cartId = HttpContext.Request.Cookies["CartId"];
        if (cartId is null)
        {
            cartId = Guid.NewGuid().ToString();
            HttpContext.Response.Cookies.Append("CartId", cartId);
        }
        if(!CartRepository.Carts.ContainsKey(cartId))
        {
            CartRepository.Carts.Add(cartId, new());
        }

        var products = new List<Product>();
        foreach(var item in CartRepository.Carts[cartId])
        {
            var product = (Product)applicationRepository.Find(typeof(Product), new Guid(item));
            if (product is not null)
            {
                products.Add(product);
            }
        }
        return View("Show", products);
    }

    [Authorize(Roles = "Member, Moderator, Administrator")]
    public IActionResult Cart([FromQuery(Name = "item-guid")]string itemGuid, [FromQuery(Name = "page-id")]string pageId)
    {
        var cartId = HttpContext.Request.Cookies["CartId"];
        if (cartId is null)
        {
            cartId = Guid.NewGuid().ToString();
            HttpContext.Response.Cookies.Append("CartId", cartId);
        }
        if (!CartRepository.Carts.ContainsKey(cartId))
        {
            CartRepository.Carts.Add(cartId, new());
        }
        if (!CartRepository.Carts[cartId].Contains(itemGuid))
        {
            CartRepository.Carts[cartId].Add(itemGuid);
        }
        return RedirectToAction("Index", "Home", new {id = pageId});
    }

   

    public IActionResult Remove([FromQuery(Name = "guid")]string guid)
    {
        var cartId = HttpContext.Request.Cookies["CartId"];
        if (cartId is null)
        {
            cartId = Guid.NewGuid().ToString();
            HttpContext.Response.Cookies.Append("CartId", cartId);
        }
        if(!CartRepository.Carts.ContainsKey(cartId))
        {
            CartRepository.Carts.Add(cartId, new());
        }
        CartRepository.Carts[cartId].Remove(guid);
        return RedirectToAction("Show");
    }

    [HttpGet]
    public IActionResult Checkout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Checkout(ShippingDetails details)
    {
        if(ModelState.IsValid)
        {
            var cartId = HttpContext.Request.Cookies["CartId"];
            if (cartId is not null)
            {
                HttpContext.Response.Cookies.Delete("CartId");
                cartId = Guid.NewGuid().ToString();
                HttpContext.Response.Cookies.Append("CartId", cartId);
            }
            return RedirectToAction("ThankYou");
        }
        else
        {
            return View("Checkout", details);
        }
    }

    [HttpGet]
    public IActionResult ThankYou()
    {
        return View("ThankYou");
    }
}
using CyberStore.Data;
using CyberStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CyberStore.Controllers;

public class ProductController : Controller
{
    ApplicationRepository applicationRepository;
    public ProductController(ApplicationRepository applicationRepository)
    {
        this.applicationRepository = applicationRepository;
    }

    [HttpGet]
    [Authorize(Roles ="Moderator, Administrator")]
    public IActionResult Index()
    {
        IEnumerable<Product> products = applicationRepository.Products.ToList();
        return View("Index", products);
    }

    [HttpGet]
    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Create()
    {
        return View("Create");
    }

    [HttpPost]
    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            applicationRepository.Add(product);
            applicationRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("Create", product);
    }

    [HttpGet]
    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Read(Guid Id)
    {
        var product = applicationRepository.Find(typeof(Product), Id);
        if (product is not null)
        {
            return View("Read", product);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Update(Guid Id)
    {
        var product = (Product)applicationRepository.Find(typeof(Product), Id);
        if (product is not null)
        {
            return View("Update", product);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost]
    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Update(Product model, Guid Id)
    {
        var product = (Product)applicationRepository.Find(typeof(Product), Id);
        if (product is not null)
        {
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Category = model.Category;
            product.Image = model.Image;
            product.SKU = model.SKU;
            product.Brand = model.Brand;
            product.IsAvailable = model.IsAvailable;
            applicationRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Delete(Guid Id)
    {
        var product = (Product)applicationRepository.Find(typeof(Product), Id);
        if (product is not null)
        {
            applicationRepository.Remove(product);
            try
            {
                applicationRepository.SaveChanges();    
            }
            catch
            {
                ;
            }
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }
}
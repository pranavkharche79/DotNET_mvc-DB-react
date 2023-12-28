using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
// using System.Collections.Generic;
using BOL;
using BLL;
namespace Portal.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult products()
    {
        CatalogManager mgr=new CatalogManager();
        List<Product> products=mgr.GetAllProducts();
        ViewData["allProducts"]=products;
        return View();
    }

}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlainWebAPI.BOL;
using PlainWebAPI.DAL;
using System.ComponentModel.DataAnnotations;
namespace PlainWebAPI.Controllers;
[ApiController]
[Route("[controller]")]

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        List<Product> plist = DBManagerP.GetAllProducts();
        return plist.ToArray();
    }


    [Route("{id}")]
    [HttpGet]
    public ActionResult<Product> GetById(int id)
    {
        Product p = DBManagerP.GetProductbyid(id);
        if (p != null)
        {
            return p;
        }
        else
        {
            return NotFound("NOT Found");
        }
    }


    // [HttpPost] 
    // [Route("api/[controller]")]
    //  public IEnumerable<Product> func1(){
    //     List<Product> plist=DBManager.GetAllProducts();
    //     return plist.ToArray();
    // }

    // public void post(Product p) {  
    //     Console.WriteLine(p.Productid);
    //     // DBManager.insertData(Id,pname,price);
    // } 



    // public IActionResult Welcome(){

    //     return View();
    // }
}

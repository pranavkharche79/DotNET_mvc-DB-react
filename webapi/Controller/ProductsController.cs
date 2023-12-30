using Microsoft.AspNetCore.Mvc;
using BOL;
// using BLL;
namespace Controllers;

// [ApiController]
// [Route("[controller]")]
// public class ProductsController : ControllerBase
// { 
//     private readonly ILogger<ProductsController> _logger;
//     public ProductsController(ILogger<ProductsController> logger)
//     {
//         _logger = logger;
//     }

//     [HttpGet]
//     public IEnumerable<Product> Get()
//     {
//         CatalogManager mgr=new CatalogManager();
//         List<Product> pro=mgr.GetAllProducts();
//         return  pro;
//     }

//     // [HttpGet("{id}")]        
//     // public Product GetById(int id)
//     // {
                
//     // }
// }


[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    // [EnableCors()]  
    public IEnumerable<Product> Get()
    {
        List<Product> allProducts=new List<Product>();
        allProducts.Add(new Product ( 1, "Gerbera", "Wedding Flower", 6));
        allProducts.Add(new Product ( 2, "Rose", "Valentine Flower", 15));
        allProducts.Add(new Product ( 3, "Lotus", "Worship Flower", 26));
        allProducts.Add(new Product ( 4, "Carnation", "Pink carnations signify a mother's love, red is for admiration and white for good luck", 16 ));
        allProducts.Add(new Product ( 5, "Lily", "Lilies are among the most popular flowers in the U.S.", 6));
        allProducts.Add(new Product ( 6, "Jasmine", "Jasmine is a genus of shrubs and vines in the olive family", 26));
        allProducts.Add(new Product ( 7, "Daisy", "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", 36));
        allProducts.Add(new Product ( 8, "Aster", "Asters are the September birth flower and the the 20th wedding anniversary flower.", 16));
        allProducts.Add(new Product ( 9, "Daffodil", "Wedding Flower", 6));
        allProducts.Add(new Product ( 10, "Dahlia", "Dahlias are a popular and glamorous summer flower.", 7));
        allProducts.Add(new Product ( 11, "Hydrangea", "Hydrangea is the fourth wedding anniversary flower", 12));
        allProducts.Add(new Product ( 12, "Orchid", "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", 10));
        allProducts.Add(new Product ( 13, "Statice", "Surprise them with this fresh, fabulous array of Statice flowers", 16));
        allProducts.Add(new Product ( 14, "Sunflower", "Sunflowers express your pure love.", 8));
        return allProducts;   
    }
}
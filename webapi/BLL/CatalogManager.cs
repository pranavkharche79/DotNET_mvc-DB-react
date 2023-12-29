namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;
public class CatalogManager{
     public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts= DBManager.GetAllProduct();
        return allProducts;
    }
}
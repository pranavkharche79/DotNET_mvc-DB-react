namespace DAL;
using BOL;

public class DBManager : IDBManager
{
    public void Delete(int id)
    {
        using (var context = new CollectionContex())
        {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
        }
    }

    public List<Product> GetAll()
    {
        using (var context =new CollectionContex())
        {
            var query= from products in context.Products select products;
            return query.ToList<Product>();
        }
    }

    public Product GetById(int id)
    {
        using (var context = new CollectionContex())
        {
            var pro= context.Products.Find(id);
            return pro; 
        }
    }

    public void Insert(Product pro)
    {
        using (var context = new CollectionContex())
        {
            context.Products.Add(pro);
            context.SaveChanges();
        }
    }

    public void Update(Product pro)
    {
        using (var context = new CollectionContex())
        {
            var pp= context.Products.Find(pro.Productid);
            pp.Title= pro.Title ;
            pp.Description= pro.Description;
            pp.Unitprice= pro.Unitprice;
            pp.Categoryid= pro.Categoryid;
            pp.Unitinstock= pro.Unitinstock;
            context.SaveChanges();
        }
    }

}
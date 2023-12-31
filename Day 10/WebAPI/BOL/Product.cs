
namespace  PlainWebAPI.BOL;
public class Product
{
    private int productid;
    private string title;
    private string picture;
    private string description;
    private int unitprice;
    public Product(){

    }
    public Product(int productId, string title,string picture,string description,int unitprice){
        this.productid = productId;
        this.title = title;
        this.picture=picture;
        this.description=description;
        this.unitprice=unitprice;
    }

    // public Product(int productId, string title,string description){
    //     this.productid = productId;
    //     this.title = title;
    //     this.description=description;
    // }

    public int Productid{
        get { return productid; }
        set { productid = value; }
    }
    
    public string Title{
            get { return title; }
            set { title = value; }
    }
        
    public string Description{
        get { return description; }
        set { description = value; }
    }

    
    public string Picture{
        get { return picture;}
        set { picture = value; }
    }
    
    public int Unitprice{
        get{  return unitprice; }
        set{  unitprice = value;}
        }

}

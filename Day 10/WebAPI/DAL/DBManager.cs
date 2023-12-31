using PlainWebAPI.BOL;
namespace PlainWebAPI.DAL;
using MySql.Data.MySqlClient;
public class DBManager{
    
    public static string conString=@"server=localhost;port=3306;user=root;password=9325874707;database=ecommerce";       
    public  static List<Product> GetAllProducts(){
           List<Product> allProduct=new List<Product>();
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            string query = "SELECT * FROM Products";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query,con);
                // cmd.Connection = con;
                con.Open();        
                // cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int productid = int.Parse(reader["productid"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                     int unitprice = int.Parse(reader["unitprice"].ToString());
                     string picture = reader["picture"].ToString();
                    Product prod=new Product(productid,title,picture,description,unitprice);

                    allProduct.Add(prod);
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }

            return allProduct;
    }

    public static Product GetProductbyid(int id){
            Product prod=null;
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            string query = "SELECT * FROM Products where productid=@id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.AddWithValue("@id",id);
                // cmd.Connection = con;
                con.Open();        
                // cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
               
                while(reader.Read()){
                    int productid = int.Parse(reader["productid"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                     int unitprice = int.Parse(reader["unitprice"].ToString());
                     string picture = reader["picture"].ToString();
                    prod=new Product(productid,title,picture,description,unitprice);
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }

            return prod;
    }
  
}

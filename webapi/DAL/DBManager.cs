namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager{
    public static string conString="server=localhost;port=3306;user=root;password=welcome;database=ecommerce";
     public  static List<Product> GetAllProduct(){
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
}
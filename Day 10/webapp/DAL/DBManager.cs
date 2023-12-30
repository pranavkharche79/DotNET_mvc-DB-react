using BOL;
namespace DAL;
using MySql.Data.MySqlClient;
public class DBManager{
    
    public static string conString=@"server=127.0.0.1;port=3306;user=root; password=welcome;database=someshdb";       
    public  static List<Product> GetAllProducts(){
            List<Product> allProduct=new List<Product>();
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            string query = "SELECT * FROM product";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();        
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int id = int.Parse(reader["pid"].ToString());
                    string name = reader["pname"].ToString();
                    double price = double.Parse(reader["price"].ToString());
                    Product dept=new Product{
                                                    Id = id,
                                                   Pname = name,
                                                    price= price
                    };
                    allProduct.Add(dept);
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

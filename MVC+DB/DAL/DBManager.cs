namespace DAL;
using BOL;

using MySql.Data.MySqlClient;

public class DBManager{
    public static string conString="server=168.192.10.139;port=3306;user=root;password=welcome;database=riderpoint";
     public  static bool ValidateUser(string uname,string pass){
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            string query = "SELECT * FROM Login";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query,con);
                // cmd.Connection = con;
                con.Open();        
                // cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    if(uname==reader["UserName"].ToString() && pass==reader["Password"].ToString())
                    {
                        return true;
                    }
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }
            return false;
    }
}
namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString= "server=localhost;port=3306;user=root;password=welcome;database=ecommerce";

    public static List<Employee> GetAllEmployees()
    {
        List<Employee> ls=new List<Employee>();
         MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        string query="Select * from employees";
        try
        {
            con.Open();
            MySqlCommand cmd=new MySqlCommand(query,con);
            MySqlDataReader reader=cmd.ExecuteReader();
             while(reader.Read())
             {
                int id=int.Parse(reader["id"].ToString());
                string name=reader["name"].ToString();
                string email=reader["email"].ToString();
                string num=reader["number"].ToString();
                Employee obj=new Employee{
                    Id=id,
                    Name=name,
                    Email=email,
                    Number=num
                };
                ls.Add(obj);
             }
             reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return ls;
    }


    public static int InsertEmployee(int id,string name,string email,string num)
    {
        int n=0;
         MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        string query="insert into employees values(@id.@name,@email,@num)";
        try
        {
            con.Open();
            MySqlCommand cmd=new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@num",num);
            n=cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return n;
        
    }
      
}

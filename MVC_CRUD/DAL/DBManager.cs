namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString = "server=localhost;port=3306;user=root;password=9325874707;database=ecommerce";

    public static List<Employee> GetAllEmployees()
    {
        List<Employee> lst = new List<Employee>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string query = "select * from employees";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int eid = int.Parse(reader["eid"].ToString());
                string ename = reader["ename"].ToString();
                string eemail = reader["eemail"].ToString();
                string enumber = reader["enumber"].ToString();
                string eaddress = reader["eaddress"].ToString();
                string egender = reader["egender"].ToString();
                Employee emp = new Employee
                {
                    Eid = eid,
                    Ename = ename,
                    Eemail = eemail,
                    Enumber = enumber,
                    Eaddress = eaddress,
                    Egender = egender
                };
                lst.Add(emp);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return lst;
    }

    public static bool AddProduct(int id, string name, string email, string num, string gender, string address)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        string query = "insert into employees values(@Id,@Name,@email,@num,@address,@gender)";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            conn.Close();
        }
        return false;
    }

}
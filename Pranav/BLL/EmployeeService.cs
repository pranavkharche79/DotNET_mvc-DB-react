namespace BLL;
using BOL;
using DAL;
public class EmployeeService
{
    public List<Employee> GetAllEmployees()
    {
        List<Employee> lst=new List<Employee>();
        lst=DBManager.GetAllEmployees();
        return lst;
    }

    public int InsertEmployee(int id,string name,string email,string num)
    {
        return DBManager.InsertEmployee(id,name,email,num);
    }
}

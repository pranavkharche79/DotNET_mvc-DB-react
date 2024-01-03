namespace BLL;
using BOL;
using DAL;
public class EmployeeService
{
    public List<Employee> GetAllEmployees()
    {
        List<Employee> lst = DBManager.GetAllEmployees();
        return lst;
    }

}
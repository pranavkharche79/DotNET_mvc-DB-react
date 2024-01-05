namespace BLL;

using System;
using BOL;
using DAL;
public class EmployeeService
{
    public bool AddProduct(int id, string name, string email, string num, string gender, string address)
    {
        return DBManager.AddProduct(id, name, email, num, gender, address);
    }

    public List<Employee> GetAllEmployees()
    {
        List<Employee> lst = DBManager.GetAllEmployees();
        return lst;
    }

}
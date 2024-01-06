using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HR_Management.Models;
using System.Collections.Generic;
using BOL;
using BLL;

namespace HR_Management.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Details()
    {
        List<Employee> lst=new List<Employee>();
        EmployeeService es=new EmployeeService();
        lst=es.GetAllEmployees();
        return View(lst);
    }
    
    public IActionResult Insert(int id,string name,string email,string num)
    {
        Console.WriteLine("ins= ",id,name,email);
        EmployeeService e=new EmployeeService();
        int n=e.InsertEmployee(id,name,email,num);
        if(n>0){
            this.RedirectToAction("Details");
        }
        return View();
    }

    public IActionResult Edit(int id)
    {
        return View();
    }

    
    public IActionResult Delete(int id)
    {
        Console.WriteLine("del= ",id);
        return this.RedirectToAction("Details");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

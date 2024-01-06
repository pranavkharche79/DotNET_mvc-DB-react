using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;
using BLL;
using BOL;

namespace FrontEnd.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult DisplayAll()
    {
        Console.WriteLine("Displayall");
        EmployeeService es = new EmployeeService();
        List<Employee> lst = es.GetAllEmployees();
        ViewData["displayall"] = lst;
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Insert(int id, string name, string email, string num, string gender, string address)
    {
        EmployeeService pd = new EmployeeService();
        bool status = pd.AddProduct(id, name, email, num, gender, address);
        if (status)
        {
            return this.RedirectToAction("DisplayAll");
        }
        return View();
    }

    [Route("Employee/Update/{id}")]
    public IActionResult Update(int id)
    {
        
        return View();
    }

    [HttpPatch]
    public IActionResult Update()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

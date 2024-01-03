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

    public IActionResult Insert()
    {
        return View();
    }
    public IActionResult DisplayAll()
    {
        EmployeeService es = new EmployeeService();
        List<Employee> lst = es.GetAllEmployees();
        return View(lst);
    }
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

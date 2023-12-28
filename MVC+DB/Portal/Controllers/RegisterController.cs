using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BLL;

namespace Portal.Controllers;

public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;

    public RegisterController(ILogger<RegisterController> logger)
    {
        _logger = logger;
    }

    public IActionResult login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult login(string uname,string pass)
    {
        Register user= new Register();
        bool flag = false;
        flag = user.ValidateUser(uname,pass);
        if(flag){
            return this.RedirectToAction("welcome");
        }
        return View();
    }

    public IActionResult welcome()
    {
        return View();
    }

}

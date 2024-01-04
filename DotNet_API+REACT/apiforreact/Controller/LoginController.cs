using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlainWebAPI.BOL;
using PlainWebAPI.DAL;
using System.ComponentModel.DataAnnotations;
namespace PlainWebAPI.Controllers;
[ApiController]
[Route("[controller]")]

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Login([FromForm] Login model)
    {
        Console.WriteLine(model.Username + " " + model.Password);
        try
        {
            List<Login> userList = DBManagerP.GetAllUsers(); // Fetch users from the database

            var user = userList.Find(u => u.Username == model.Username && u.Password == model.Password);

            if (user != null)
            {
                return Ok(new { message = "Login successful done" });
            }

            return Unauthorized(new { message = "Invalid credentials" });
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine("Exception occurred: " + ex.Message);
            return StatusCode(500); // Internal Server Error
        }
    }
}

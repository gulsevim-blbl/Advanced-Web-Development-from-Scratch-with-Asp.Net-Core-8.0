using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnetcore_basics.Models;

namespace aspnetcore_basics.Controllers;

public class HomeController : Controller
{
  
    public IActionResult Index()
    {
        return View(Repostory.Courses);
    }

    public IActionResult Contact()
    {
        return  View();
    }
    public IActionResult About()
    {
        return View();
    }
    
   
}

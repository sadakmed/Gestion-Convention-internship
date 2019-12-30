using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gestion_Convention_stage.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gestion_Convention_stage.Contexts;


namespace Gestion_Convention_stage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {   
            


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

          public IActionResult login(Student st)
        {
          Console.WriteLine(MyContext.loginAccessStudent(st));     
          if (MyContext.loginAccessStudent(st)){
              Console.WriteLine("in student controller");

          }             
          else if (MyContext.loginAccessAdmin(st)) {

              Console.WriteLine("in admin controller");
          }
          else {

              Console.WriteLine("access access denied");
          }
                
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

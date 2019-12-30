using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gestion_Convention_stage.Models;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gestion_Convention_stage.Controllers
{
    public class StudentController:Controller
    {
         public IActionResult Signup()
        {
            return View();
        }
        public void saveStudent(Student student){

            Console.WriteLine(student.apoge);

            Response.Redirect("Signup",true);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
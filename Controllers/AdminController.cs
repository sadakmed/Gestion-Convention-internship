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
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Demandes()
        {   List<Student> list = new List<Student>();
          
            return View( MyContext.fetchDemands());
        }

        public void validate(int id){
              
               MyContext.updateDemandeStatus(id,1);
                Response.Redirect("Demandes",true);
               }
       
         public void refuse(int id){

                MyContext.updateDemandeStatus(id,-1);
                Response.Redirect("Demandes",true);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

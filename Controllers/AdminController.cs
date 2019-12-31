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
using Gestion_Convention_stage.Utils;
using Newtonsoft.Json;


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
        {   
            return View( MyContext.fetchDemands());
        }

         public IActionResult History()
        {   
            ViewData["demandes"] = JsonConvert.SerializeObject(MyContext.fetchAllDemands());

            return View( );
        }

        public void validate(int id){
              
               MyContext.updateDemandeStatus(id,1);
               Mail.sendMail("" , "sadak_med@protonmail.com", "votre demande etait accepté" ,"Votre demande est pres au service de scolarite");
                Response.Redirect("Demandes",true);
               }
       
         public void refuse(int id){

                MyContext.updateDemandeStatus(id,-1);
               Mail.sendMail("" , "sadak_med@protonmail.com", "votre demande etait Refuse" ,"Votre demande est refuse change sil vvous plais merci.");
                Response.Redirect("Demandes",true);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

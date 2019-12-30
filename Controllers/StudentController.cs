using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gestion_Convention_stage.Models;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gestion_Convention_stage.Contexts;

namespace Gestion_Convention_stage.Controllers
{
    public class StudentController:Controller
    {
     
        public int apoge { get; set; }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Demande()
        {
            return View();
        }

        public IActionResult History()


        {   List<Demande> demandeList= new List<Demande>();
            
            demandeList=MyContext.fetchDemandeStudent(this.apoge); 
            
            return View(demandeList);
        }

        public void saveStudent(Student student){

            this.apoge=student.apoge;
            student.demande=0;
            
            

            MyContext.InsertStudent(student);

            Response.Redirect("Demande",true);
        }
        public void saveDemande(Demande de){
            de.idStudent=this.apoge;
            de.status=0;
            MyContext.InsertDemande(de);
            Response.Redirect("History",true);


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using Gestion_Convention_stage.Contexts;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gestion_Convention_stage.Models
{
[Table("student")]
public class Student{
  
    [Required]
    [DisplayName("N° Apoge")]
    public int apoge{ get;set; }

    [Required]
    [DisplayName("First Name")] 
    public string f_name{ get;set; }

    [Required]
    [DisplayName("Last Name")]
    public string l_name{ get;set; }

    [Required]
    [DisplayName("Email")]
    public string email{ get;set; }

    [Required]
    [DisplayName("Major")]
    public string major{ get;set; }

    [Required]
    [DisplayName("Password")]
    [DataType(DataType.Password)]
    public string password{get;set;}
    
    public int demande{ get;set; }

    public int checkData(){

        using (var context = new LibraryContext())
      {
        var AdminsDB = context.student;        
     
        foreach(var a in AdminsDB){
            if (this.apoge == a.apoge){
                Console.WriteLine("In DataBase");
                return 1 ;
            }
        }
        Console.WriteLine("Not In DataBase");
        return 0 ;

    }
}
    
    
  

}


}
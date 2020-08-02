using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gestion_Convention_stage.Contexts;

namespace Gestion_Convention_stage.Models
{

[Table("demande")]
public class Demande{

    public int id{get;set;}
    public int idStudent{get;set;}

    [Required]
    [DisplayName("Academic Supervisor")]
    public string intern_supervisor{get;set;}


    [Required]
    [DisplayName("Company Supervisor")]
    public string extern_supervisor{get;set;}


    [Required]
    [DisplayName("Company")]
    public string company{get;set;}


    [Required]
    [DisplayName("Date From")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime from_date{get;set;}

    
    [Required]
    [DisplayName("Date To")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime to_date{get;set;}

    public int status{get;set;}


    public int checkDemande(){

        using (var context = new LibraryContext())
      {
        var demandeDB = context.demande;        
     
        foreach(var a in demandeDB){
            if (this.idStudent == a.idStudent && a.status != -1 ){
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

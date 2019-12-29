using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 

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
    public DateTime from_date{get;set;}

    
    [Required]
    [DisplayName("Date To")]
    public DateTime to_date{get;set;}


 


    
}





}
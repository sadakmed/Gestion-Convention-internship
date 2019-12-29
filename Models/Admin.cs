using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Convention_stage.Models
{
[Table("Admin")]
public class Admin{
  
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
    [DisplayName("Password")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)]
    public string Password{get;set;}
    




}
}
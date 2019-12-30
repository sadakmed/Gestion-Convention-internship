using System.Text;
using Gestion_Convention_stage.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Gestion_Convention_stage.Contexts
{

  public class MyContext
  {


    public static bool loginAccessStudent(Student st){
    
      using (var context = new LibraryContext()){
        var StudentDB = context.student; 
        foreach(var a in StudentDB){
        if (st.email == a.email && st.password == a.password ){
          return true ;
            }
            }
        
            return false ;
          } 
    }



    public static bool loginAccessAdmin(Student st){
    
      using (var context = new LibraryContext()){
        var AdminsDB = context.admins; 
        foreach(var a in AdminsDB){
        if (st.email == a.email && st.password == a.password ){
          return true ;
            }
            }
        
            return false ;
          } 
    }


     public static void InsertStudent(Student st)
    {
      using(var context = new LibraryContext())
      {
        // Creates the database if not exists
        context.Database.EnsureCreated();
        
        if (st.checkData()== 0){
    
        // Adds admins
        context.student.Add(new Student
        {
            apoge = st.apoge,
            l_name = st.l_name,
            f_name = st.f_name,
            email  = st.email,
            major  = st.major,
            password= st.password,
            demande = 0
        });
       

        // Saves changes
        context.SaveChanges();
      }

      }
    }


    public static void InsertDemande(Demande de)
    {
      using(var context = new LibraryContext())
      {
        // Creates the database if not exists
        context.Database.EnsureCreated();
        
        if (de.checkDemande() == 0){
    
        // Adds admins
        context.demande.Add(new Demande
        {
            intern_supervisor = de.intern_supervisor,
            extern_supervisor = de.extern_supervisor,
            company = de.company,
            idStudent= de.idStudent
        });
       

        // Saves changes
        context.SaveChanges();
      }
      }
    }

   
   public static void fetchStudent()
    {
      // Gets and prints all books in database
      using (var context = new LibraryContext())
      {
        var Admins = context.student;
        // foreach(var a in Admins)
        // {
        //   var data = new StringBuilder();
        //   data.AppendLine($"ID: {a.apoge}");
        //   data.AppendLine($"name: {a.name}");
        //   Console.WriteLine(data.ToString());
        // }
      }
    }


  
  


 
  }
}
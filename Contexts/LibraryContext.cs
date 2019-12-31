using Gestion_Convention_stage.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Gestion_Convention_stage.Contexts
{

  public class LibraryContext : DbContext
  {
    public DbSet<Student> student { get; set; }
    public DbSet<Demande> demande {get;set;}
    public DbSet<Admin> admins{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=stage;user=root;password= ");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Student>(entity =>{ 
          entity.HasKey(e => e.apoge); 
          entity.Property(e => e.f_name).IsRequired();
          entity.Property(e => e.l_name).IsRequired();
          entity.Property(e => e.email).IsRequired();
          entity.Property(e => e.password).IsRequired();
          entity.Property(e => e.major).IsRequired();
          entity.Property(e => e.demande);
      });

      modelBuilder.Entity<Demande>(entity =>{ 
          entity.HasKey(e => e.id); 
          entity.Property(e => e.idStudent).IsRequired();
          entity.Property(e => e.intern_supervisor).IsRequired();
          entity.Property(e => e.extern_supervisor).IsRequired();
          entity.Property(e => e.from_date).IsRequired();
          entity.Property(e => e.to_date).IsRequired();
          entity.Property(e => e.company).IsRequired();
           entity.Property(e => e.status).IsRequired();




      });

      modelBuilder.Entity<Admin>(entity =>{ 
          entity.HasKey(e => e.email); 
          entity.Property(e => e.f_name).IsRequired();
          entity.Property(e => e.l_name).IsRequired();
          entity.Property(e => e.password).IsRequired();

      });

      
    }
  }
}
using KathakBookingSystem.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace KathakBookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
     public ApplicationDbContext(){}
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=KathakBookingDB;trusted_connection=false;Persist Security Info=false;Encrypt=false");
            }
        }
        // Write your ApplicationDbContext here...
    }
}

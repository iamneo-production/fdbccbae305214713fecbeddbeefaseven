using KathakBookingSystem.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace KathakBookingSystem.Data
{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(){}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=KathakBookingDB;trusted_connection=false;Persist Security Info=false;Encrypt=false");
            }
        }
        // Write your ApplicationDbContext here...
    }
}

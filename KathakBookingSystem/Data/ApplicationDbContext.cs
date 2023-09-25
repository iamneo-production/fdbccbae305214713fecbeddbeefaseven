﻿using KathakBookingSystem.Models;
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

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        // Write your ApplicationDbContext here...
    }
        // Write your ApplicationDbContext here...
    }
}

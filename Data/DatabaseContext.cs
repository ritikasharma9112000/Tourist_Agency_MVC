using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tourist_Agency_MVC.Models;

namespace Tourist_Agency_MVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Tourist_Agency_MVC.Models.Activities> Activities { get; set; }

        public DbSet<Tourist_Agency_MVC.Models.Agency> Agency { get; set; }

        public DbSet<Tourist_Agency_MVC.Models.Customer> Customer { get; set; }

        public DbSet<Tourist_Agency_MVC.Models.Booking> Booking { get; set; }

        public DbSet<Tourist_Agency_MVC.Models.Packages> Packages { get; set; }
    }
}

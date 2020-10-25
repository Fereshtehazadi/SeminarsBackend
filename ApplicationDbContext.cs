using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarie
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Seminar> Seminars { get; set; }
        public DbSet<Visitor> Visitors { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TravelUnion2;Trusted_Connection=True;");   
        }

    }
}

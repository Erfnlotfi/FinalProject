using Microsoft.EntityFrameworkCore;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FinalDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1F3UU3Q;Initial Catalog=FinalProject;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> product { get; set; }
    }
}

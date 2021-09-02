using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Entities;

namespace Uygulama.DataAccess
{
    public class PersonDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=******;Database=PersonDb; User Id= sa; Password= ******;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Person> Persons { get; set; }
    }
}

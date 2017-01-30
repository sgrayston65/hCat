using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Models
{
    public class PersonInfoContext : DbContext
    {
        public PersonInfoContext(DbContextOptions<PersonInfoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
    }
}

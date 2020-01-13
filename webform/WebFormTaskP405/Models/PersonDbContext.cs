using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebFormTaskP405.Models;

namespace WebFormTaskP405.Models
{
    public class PersonDbContext:DbContext
    {
        public PersonDbContext():base("myDb") { }

        public DbSet<Person> People { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Asignment.Models
{
    public class Connection : DbContext
    {
        public Connection()
            : base("MyConnectionString")
        { }
        public DbSet<Student> Students { get; set; }
    }
}
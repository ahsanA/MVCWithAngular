using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AngularMCV.Models
{
    public class Database : DbContext
    {
        public DbSet<Employee> employee { get; set; }
    }
}
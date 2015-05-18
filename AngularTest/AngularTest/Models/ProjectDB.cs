using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class ProjectDB:DbContext
    {
        public ProjectDB() : base("AngularTest") 
        {
 
        }

        public DbSet<Student> Students { get; set; }
    }
}
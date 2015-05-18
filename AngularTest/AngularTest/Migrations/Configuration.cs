namespace AngularTest.Migrations
{
    using AngularTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularTest.Models.ProjectDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularTest.Models.ProjectDB context)
        {
            var students = new List<Student>
            {
                new Student { Name = "Carson",   Status = "false" },
                new Student { Name = "Ahsan",   Status = "false" },
                new Student { Name = "Tania",   Status = "true" },
                new Student { Name = "Urmee",   Status = "false" }
            };
            students.ForEach(s => context.Students.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}

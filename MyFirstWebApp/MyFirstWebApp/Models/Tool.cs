using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class Tool
    {
        // Simple POCO (plain old CLR objects) class will allow the
        // entity framework to create a DB based on it
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsExperienced { get; set; }

        public int YearsOfExperience { get; set; }

        public DateTime YearFirstUsed { get; set; }
    }

    // The Entity framework DbContext class handles the fetching, storing
    // and updating of Tool instances in a database, effectively maps Tool
    // objects to records (rows in a database table)
    public class ToolDbContext : DbContext
    {
        public DbSet<Tool> Tools { get; set; }
    }
}
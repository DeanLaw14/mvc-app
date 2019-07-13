using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class Tool
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsExperienced { get; set; }

        public int YearsOfExperience { get; set; }

        public DateTime YearFirstUsed { get; set; }
    }
}
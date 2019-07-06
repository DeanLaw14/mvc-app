using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class PersonModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public int Age { get; set; }

        [DisplayName("Is Person Active")]
        public bool IsActive { get; set; }
    }
}
using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            var people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Dean", LastName= "Akinwale", Age = 27, IsActive = false });
            people.Add(new PersonModel { FirstName = "Sis", LastName= "Akinwale", Age = 29, IsActive = true });
            people.Add(new PersonModel { FirstName = "Bro", LastName= "Akinwale", Age = 25, IsActive = true });

            return View(people);
        }
    }
}
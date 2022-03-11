using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculatePremiumWebApp.Models;

namespace CalculatePremiumWebApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Person person = new Person();
            person.Occupations = person.GetOccupationsList();
            return View(person);
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            float occupationRate = GetOccupationRate(person.Occupation);
            person.Premium = ((person.SumInsured * occupationRate * person.Age) / 1000 * 12).ToString();
            person.Occupations = person.GetOccupationsList();
            return View(person);
        }

        private float GetOccupationRate(string occupation)
        {
            switch (occupation)
            {
                case "Professional":
                    return 1.0F;
                case "WhiteCollar":
                    return 1.25F;
                case "LightManual":
                    return 1.5F;
                case "HeavyManual":
                    return 1.75F;
            }
            return 0F;
        }

    }
}
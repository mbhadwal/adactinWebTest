using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatePremiumWebApp.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public int SumInsured { get; set; }
        public string Premium { get; set; }  
        public string Occupation { get; set; }
        public List<SelectListItem> Occupations { get; set; }
        public List<SelectListItem> GetOccupationsList()
        {
            List<SelectListItem> occupationList = new List<SelectListItem>();
            occupationList.Add(new SelectListItem { Value = "WhiteCollar", Text = "Author" });
            occupationList.Add(new SelectListItem { Value = "LightManual", Text = "Cleaner" });
            occupationList.Add(new SelectListItem { Value = "Professional", Text = "Doctor" });
            occupationList.Add(new SelectListItem { Value = "HeavyManual", Text = "Farmer" });
            occupationList.Add(new SelectListItem { Value = "LightManual", Text = "Florist" });
            occupationList.Add(new SelectListItem { Value = "HeavyManual", Text = "Mechanic" });

            return occupationList;
        }

    }
}
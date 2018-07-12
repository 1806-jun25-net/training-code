using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Pizza
    {
        string TypeOfPizza { get; set; }

        public List<SelectListItem> AllTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "cheese", Text = "Cheese" },
            new SelectListItem { Value = "pepp", Text = "Pepperoni" }
        };
    }
}

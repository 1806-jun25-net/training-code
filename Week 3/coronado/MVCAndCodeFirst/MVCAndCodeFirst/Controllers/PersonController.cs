using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCAndCodeFirst.Controllers
{
    public class PersonController : Controller
    {
        [Route("Person/Index")]
        public IActionResult Index()
        {
            [Route("Person/Index")]
            return View();
        }
    }
}
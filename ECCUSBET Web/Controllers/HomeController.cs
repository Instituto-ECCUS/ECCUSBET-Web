using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult BemVindo()
        {
            return View();
        }
    }
}

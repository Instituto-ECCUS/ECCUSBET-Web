using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Controllers
{
    /// <summary>
    /// Responssável por gerenciar a chamada e responta do manual de usuário
    /// </summary>
    public class ManualController : Controller
    {
        public IActionResult Manual()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCObject.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(string Name)
        {
            ViewData["Message"] = $"Hhello {Name} from MVC";
            ViewBag.Name = Name;
            return View();
        }
    }
}
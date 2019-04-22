using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppMVCObject.Models;

namespace WebAppMVCObject.Controllers
{
    public class RPGController : Controller
    {
        List<IRPG> rpg;

        public RPGController()
        {
            rpg = new List<IRPG>()
            {
                new Fighter(),
                new Wizard()
            };
        }

        public ActionResult Index()
        {
            return View(rpg);
        }

        public ActionResult Details(string Name)
        {
            return View(rpg.Where(n => n.Name == Name).FirstOrDefault());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {

            return View(rpg[id]);
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
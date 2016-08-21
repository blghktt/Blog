using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog3.Models;

namespace Blog3.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        public static List<EditModel> bejegyzesek = new List<EditModel>();
        private static int idGenerator = 0;

        public ActionResult Index()
        {
            return View(bejegyzesek);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View("Edit");
        }

        [HttpPost]
        public ActionResult Edit(EditModel bejegyzes)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }
            bejegyzesek.Insert(0, new EditModel(idGenerator, bejegyzes.Cim, bejegyzes.Tartalom, DateTime.Now));
            idGenerator++;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Szerkesztes(int id)
        {
            return View("Edit", bejegyzesek.Single(p => p.Id == id));
        }

        [HttpPost]
        public ActionResult Szerkesztes(EditModel bejegyzes)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", bejegyzes);
            }
            var act = bejegyzesek.Single(p => p.Id == bejegyzes.Id);
            act.Cim = bejegyzes.Cim;
            act.Tartalom = bejegyzes.Tartalom;
            
            return RedirectToAction("Index");
        }
    }
}
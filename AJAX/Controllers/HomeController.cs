using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAX.Models;

namespace AJAX.Controllers
{
    public class HomeController : Controller
    {
        PropertyDBContext db = new PropertyDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            var model = db.Properties.ToList();
            return PartialView("_Property", model);

        public PartialViewResult Top3()
        {
            var model = db.Properties.OrderByDescending(p => p.Price).Take(3).ToList();
            return PartialView("_Property", model);
        }

        public PartialViewResult Bottom3()
        {
            var model = db.Properties.OrderBy(p => p.Price).Take(3).ToList();
            return PartialView("_Property", model);
        }
    }
}
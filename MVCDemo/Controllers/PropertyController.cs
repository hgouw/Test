using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    [System.Runtime.InteropServices.GuidAttribute("B27E542D-848B-4650-B8CD-A396B31919F7")]
    public class PropertyController : Controller
    {
        public ActionResult List()
        {
            var propertyContext = new PropertyContext();
            var properties = propertyContext.Properties.ToList();

            return View(properties);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    foreach (var key in formCollection.AllKeys)
        //    {
        //        Response.Write(string.Format("{0} - {1}<br/>", key, formCollection[key]));
        //    }
        //    return View();
        //}
        public ActionResult Create(Property property)
        {
            if (ModelState.IsValid)
            {
                // Save the property
                return RedirectToAction("List");
            }
            return View();
        }
    }
}
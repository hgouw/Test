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
        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Property/List
        /// </summary>
        public ActionResult List()
        {
            var propertyContext = new PropertyContext();
            var properties = propertyContext.Properties.ToList();

            return View(properties);
        }

        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Property/Create
        /// </summary>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Property property)
        {
            if (ModelState.IsValid)
            {
                var propertyContext = new PropertyContext();
                propertyContext.Properties.Add(property);
                propertyContext.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
        }

        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Property/Edit?number=8&street=Abbey%20Place&suburb=Cherrybrook&state=NSW&postcode=2126
        /// </summary>
        [HttpGet]
        public ActionResult Edit(string number, string street, string suburb, string state, string postcode)
        {
            var propertyContext = new PropertyContext();
            var property = propertyContext.Properties.Single(p => p.Number == number && p.Street == street && p.Suburb == suburb);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        [HttpPost]
        public ActionResult Edit(Property property)
        {
            if (ModelState.IsValid)
            {
                var propertyContext = new PropertyContext();
                propertyContext.Properties.Add(property);
                propertyContext.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class FamilyController : Controller
    {
        /// <summary>
        /// To display this page type in http://localhost/MVC/Family/Members
        /// </summary>
        public ActionResult Members()
        {
            ViewBag.Members =
                new List<string>
                {
                    "Herman",
                    "Helen",
                    "Sarah",
                    "Olivia"
                };
            return View();
        }
    }
}
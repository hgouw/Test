using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class CompanyController : Controller
    {
        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Company/Details
        /// </summary>
        /// <returns></returns>
        public ActionResult Details()
        {
            Company company =
                new Company
                {
                    Code = "CPU",
                    Name = "COMPUTERSHARE LIMITED",
                    Group = "Software & Services"
                };
            return View(company);
        }
    }
}
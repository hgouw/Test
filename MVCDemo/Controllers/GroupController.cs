using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class GroupController : Controller
    {
        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Group/List
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var companyContext = new CompanyContext();
            var groups = companyContext.IndustryGroups.ToList();
            return View(groups);
        }
    }
}
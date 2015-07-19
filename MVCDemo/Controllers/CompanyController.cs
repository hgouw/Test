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
        /// To display this page type in http://localhost/MVCDemo/Company/List?group=Group
        /// </summary>
        public ActionResult List(string group)
        {
            var companyContext = new CompanyContext();
            var companies = companyContext.Companies.Where(c => c.Group == group).ToList();
            return View(companies);
        }
        
        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Company/Details?code=CompanyCode
        /// </summary>
        public ActionResult Details(string code)
        {
            //Company company =
            //    new Company
            //    {
            //        Code = "CPU",
            //        Name = "COMPUTERSHARE LIMITED",
            //        Group = "Software & Services"
            //    };

            var companyContext = new CompanyContext();
            var company = companyContext.Companies.Single(c => c.Code == code);
            return View(company);
        }
    }
}
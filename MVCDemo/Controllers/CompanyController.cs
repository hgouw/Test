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
        /// To display this page type in http://localhost/MVCDemo/Company/Display
        /// </summary>
        /// <returns></returns>
        public ActionResult Display()
        {
            CompanyContext companyContext = new CompanyContext();
            var companies = companyContext.Companies.ToList();
            return View(companies);
        }
        
        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Company/Details/xyz
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            //Company company =
            //    new Company
            //    {
            //        Code = "CPU",
            //        Name = "COMPUTERSHARE LIMITED",
            //        Group = "Software & Services"
            //    };

            CompanyContext companyContext = new CompanyContext();
            var company = companyContext.Companies.Single(c => c.Code == id);
            return View(company);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// To display this page type in http://localhost/MVCDemo/Home/Home/xx?querystr1=yy&querystr2=zz
        /// where id, querystr1 and querystr2 are optional
        /// </summary>
        public string Home(string id, string querystr1, string querystr2)
        {
            var output = "Hello World!";
            if (!String.IsNullOrEmpty(id))
            {
                output = String.Format("Id - {0}", id);
                if (!String.IsNullOrEmpty(querystr1))
                {
                    output = String.Format("{0} - {1}", output, querystr1);
                    if (!String.IsNullOrEmpty(querystr2))
                    {
                        output = String.Format("{0} - {1}", output, querystr2);
                    }
                }
            }
            return output;
        }
    }
}
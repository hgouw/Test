using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeoLocationWeb
{
    public partial class GeoLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ipAddress = GetIPAddress(); // "203.110.137.58"
            var ipResponse = GetCountryByIP(ipAddress);
        }

        public string GetIPAddress()
        {
            HttpContext context = HttpContext.Current;
            string s1 = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            string s2 = context.Request.ServerVariables["REMOTE_ADDR"];
            return s1;

            //string Str = "";
            //Str = System.Net.Dns.GetHostName();
            //IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(Str);
            //IPAddress[] addr = ipEntry.AddressList;
            //return addr[addr.Length - 1].ToString();

            //HttpContext context = HttpContext.Current;
            //string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            //if (!string.IsNullOrEmpty(ipAddress))
            //{
            //    string[] addresses = ipAddress.Split(',');
            //    if (addresses.Length != 0)
            //    {
            //        return addresses[0];
            //    }
            //}
            //return context.Request.ServerVariables["REMOTE_ADDR"];
        }

        public Location GetCountryByIP(string ipAddress)
        {
            string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + ipAddress);
            using (TextReader sr = new StringReader(ipResponse))
            {
                using (System.Data.DataSet dataBase = new System.Data.DataSet())
                {
                    Location location = new Location();
                    dataBase.ReadXml(sr);
                    location.Latitude = dataBase.Tables[0].Rows[0][7].ToString();
                    location.Longitude = dataBase.Tables[0].Rows[0][8].ToString();
                    return location;
                }
            }
        }

        public string IPRequestHelper(string url)
        {
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }
    }
}
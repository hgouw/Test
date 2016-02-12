using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

// Web API Client using
// .NET Framework 4.0
// Microsoft HTTP Client Libraries 2.2.18
// 

namespace WebApiClient_4
{
    public class Dl
    {
        public int DlId { get; set; }
        public string Dpsi { get; set; }
        public string DlTitle { get; set; }
    }

    public class Dls : List<Dl>
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://lnred-prod-test.cloudapp.net");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("digital.library.api/api/Packaging/GetDlDpsiList").Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultString = response.Content.ReadAsStringAsync().Result;
                    var dls  = JsonConvert.DeserializeObject<Dls>(resultString);
                }
            }
        }
    }
}
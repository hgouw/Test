﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Net.Http.Formatting;

namespace WebApiClient
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
                    var dls = response.Content.ReadAsAsync<Dls>();
                }
            }
        }
    }
}
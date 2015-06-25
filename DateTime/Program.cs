using System;
using System.Globalization;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "9 Jun 2014";
            //string s = "18 Sep 2014 10:15:36 AM GMT+10:00";
            //string s = "18 Sep 2014 10:15:36 PM GMT+10:00";
            //System.DateTime dt = System.DateTime.ParseExact(s, "dd MMM yyyy hh:mm:ss tt 'GMT'K", CultureInfo.InvariantCulture);
            System.DateTime dt = System.DateTime.ParseExact(s, "d MMM yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt);
            Console.ReadLine();
        }
    }
}

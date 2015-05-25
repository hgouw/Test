using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var timesheets = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var authorizationRequests = new int[] { 2, 4, 5, 7, 9, 11 };
            var selectedTimesheets = timesheets.Where(x => authorizationRequests.Contains(x)).ToList();
            foreach (int i in selectedTimesheets)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
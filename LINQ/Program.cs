using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class LINQExtension
    {
        public static double Median(this IEnumerable<double> source)
        {
            if (source.Count() == 0)
            {
                throw new InvalidOperationException("Cannot compute median for an empty set.");
            }

            var sortedList = from number in source
                             orderby number
                             select number;

            int itemIndex = (int)sortedList.Count() / 2;

            if (sortedList.Count() % 2 == 0)
            {
                // Even number of items. 
                return (sortedList.ElementAt(itemIndex) + sortedList.ElementAt(itemIndex - 1)) / 2;
            }
            else
            {
                // Odd number of items. 
                return sortedList.ElementAt(itemIndex);
            }
        }
    }

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
            Console.WriteLine();

            string[] colours = { "green", "brown", "blue", "red" };
            var query1 = from c in colours
                         where c.Length == colours.Max(x => x.Length)
                         select c;
            foreach (var element in query1)
                Console.WriteLine(element);
            Console.WriteLine();

            var query2 = colours.Where(x => x.Length == x.Max()); // TODO - using max
            foreach (var element in query2)
                Console.WriteLine(element);
            Console.WriteLine();

            double[] numbers1 = { 1.9, 2, 8, 4, 5.7, 6, 7.2, 0 };
            var median = numbers1.Median();
            Console.WriteLine("Median = " + median);
            Console.WriteLine();

            var names = new string[] { "Herman", "Helen", "Sarah", "Olivia" };
            var n = names.OrderBy(x => x.Length); // sorted by length from min to max
            foreach (string name in n)
                Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
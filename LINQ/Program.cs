﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static class LINQExtension
    {
        /// <summary>
        /// Median is an extension method to LINQ
        /// </summary>
        public static double Median(this IEnumerable<double> source)
        {
            if (source.Count() == 0)
            {
                throw new InvalidOperationException("Cannot compute median for an empty set.");
            }

            /*
            var sortedList = from number in source
                             orderby number
                             select number;
            */
            var sortedList = source.OrderBy(x => x);

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

        static IList<string> CreateCollection()
        {
            return new List<string>() { "Herman", "Helen", "Sarah", "Olivia" };
        }

        static IList<Person> CreateFamily()
        {
            return new List<Person>() {
                                        new Person { Name = "Herman", Age = 55 },
                                        new Person { Name = "Helen", Age = 43 },
                                        new Person { Name = "Sarah", Age = 11 },
                                        new Person { Name = "Olivia", Age = 7 }
                                      };

        }

        static void Main(string[] args)
        {
            var ints1 = new int[3];
            ints1[0] = 4;
            ints1[1] = 3;
            ints1[2] = 0;

            // Array 2.
            var ints2 = new int[3];
            ints2[0] = 5;
            ints2[1] = 4;
            ints2[2] = 2;

            var result = ints1.Join<int, int, int, int>(ints2,
                                                        x => x + 1,
                                                        y => y,
                                                        (x, y) => x);
            
            var postCodes = new string[] { "NSW", "NT", "QLD", "SA", "TAS", "VIC", "WA" };
            var states = new string[] { "New South Wales", "Northern Territory", "Queensland", "South Australia", "Tasmania", "Victoria", "Western Australia" };
            var statesWithCodes = postCodes.Zip(states, (code, state) => code + " - " + state);
            foreach (var state in statesWithCodes)
                Console.WriteLine(state);
            Console.ReadLine();

            var bigList = Enumerable.Range(1, 20);
            var smallList = bigList.Take(6).Select(i => i * 100);
            foreach (var i in smallList)
                Console.WriteLine(i);
            Console.ReadLine();

            var query = from method in typeof(double).GetMethods()
                        orderby method.Name
                        group method by method.Name into groups
                        select new { MethodName = groups.Key, NoOfOverloads = groups.Count() };

            foreach (var item in query)
                Console.WriteLine(item);
            Console.ReadLine();

            var collection = CreateCollection();
            foreach (var s in collection)
            {
                Console.WriteLine(s);
            }
            var family = CreateFamily();
            foreach (var p in family)
            {
                Console.WriteLine(p.Age);
            }
            var adults = from p in family where p.Age > 17 select p; // Query syntax (SQL like query expression)
            var kids = family.Where(p => p.Age < 18);  // Lambda syntax (Lambda expression)
            foreach (var p in adults)
            {
                Console.WriteLine(p.Name);
            }
            foreach (var p in kids)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine();
            
            var timesheets = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var authorizationRequests = new int[] { 2, 4, 5, 7, 9, 11 };
            var selectedTimesheets = timesheets.Where(x => authorizationRequests.Contains(x));
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

            var query2 = colours.Where(x => x.Length == x.Min()); // TODO - using max
            foreach (var element in query2)
                Console.WriteLine(element);
            Console.WriteLine();

            double[] numbers1 = { 1.9, 2, 8, 4, 5.7, 6, 7.2, 0 };
            var median = numbers1.Median(); // Median is an extension method to LINQ
            Console.WriteLine("Median = " + median);
            Console.WriteLine();

            var gouw = new string[] { "Herman", "Helen", "Sarah", "Olivia" };
            var names = gouw.OrderBy(x => x.Length); // sorted by length from min to max (ascending)
            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine();
            var sortest = gouw.Min(x => x.Length); // get shortest length of the names
            Console.WriteLine(sortest);

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    class Program
    {
        public class Instrument { };
        public class Stock : Instrument { };
        public class Future : Instrument { };
        public class Option : Instrument { };

        static void Main()
        {
            /*
            SortedList<string, Instrument> instruments = new SortedList<string, Instrument> { };
            Stock stock = new Stock();
            Future future = new Future();
            Option option = new Option();

            instruments.Add(nameof(stock), stock);
            instruments.Add(nameof(future), future);
            instruments.Add(nameof(option), option);
            foreach (var instrument in instruments)
                Console.WriteLine(instrument.Value);
            Console.ReadLine();
            */

            //string[] names = { "Helen", "Herman", "1Sarah", "Olivia" };
            //var nameList = new List<string>();
            //nameList.AddRange(names);
            ////nameList.Sort();

            ////foreach (var name in nameList)
            //foreach (var name in nameList.OrderBy(n => n))
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //string[] titles = {
            //                    "1",
            //                    "0",
            //                    "z",
            //                    "a"
            //                  };

            string[] titles = {
                                "2010 Richies uniform procedure rules NSW HV + Cases",
                                "Richies uniform procedure rules NSW + Cases",
                                "2010 Richies uniform procedure rules NSW HV",
                                "Richies uniform procedure rules NSW",
                              };

            var orderedTitles = titles.OrderBy(x => x, new TitleComparer());
            foreach (var title in orderedTitles)
            {
                Console.WriteLine(title);
            }
            Console.ReadLine();

            string[] names = { "john", "paul", "ringo", "george", "janis" };
            var orderedNames = names.OrderByDescending(x => x, new CustomStringComparer());
            foreach (var name in orderedNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
 }
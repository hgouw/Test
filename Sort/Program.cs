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

        static void Main(string[] args)
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

            string[] names = { "Helen", "Herman", "1Sarah", "Olivia" };
            var nameList = new List<string>();
            nameList.AddRange(names);
            //nameList.Sort();

            //foreach (var name in nameList)
            foreach (var name in nameList.OrderBy(n => n))
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
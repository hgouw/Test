using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Instrument> instruments = new List<Instrument> { };
            Stock stock = new Stock();
            Future future = new Future();
            Option option = new Option();

            //TODO - sort a list of classes
            instruments.Add(stock);
            instruments.Add(future);
            instruments.Add(option);
            instruments.Sort();
            foreach (Instrument instrument in instruments)
                Console.WriteLine(instrument.ToString());
            Console.ReadLine();
        }

        public class Instrument { };
        public class Stock : Instrument { };
        public class Future : Instrument { };
        public class Option : Instrument { };
    }
}

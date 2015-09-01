using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace CSV
{
    public class EndOfDay
    {
        public virtual string Code { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal Open { get; set; }
        public virtual decimal High { get; set; }
        public virtual decimal Low { get; set; }
        public virtual decimal Last { get; set; }
        public virtual int Volume { get; set; }
    }

    public sealed class EndOfDayMap : CsvClassMap<EndOfDay>
    {
        public EndOfDayMap()
        {
            Map(m => m.Code).Name("Code");
            Map(m => m.Date).Name("Date").TypeConverterOption("yyyyMMdd");
            Map(m => m.Open).Name("Open");
            Map(m => m.High).Name("High");
            Map(m => m.Low).Name("Low");
            Map(m => m.Last).Name("Last");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader csvReader = File.OpenText(@"..\..\Data\Test.csv");

            using (var parser = new CsvParser(csvReader))
            {
                while (true)
                {
                    var row = parser.Read();
                    if (row == null)
                    {
                        break;
                    }
                }
            }

            using (var csv = new CsvReader(csvReader))
            {
                csv.Configuration.RegisterClassMap<EndOfDayMap>();
                while (csv.Read())
                {
                    var record = csv.GetRecord<EndOfDay>();
                }
            }

            using (var csv = new CsvReader(csvReader))
            {
                csv.Configuration.RegisterClassMap<EndOfDayMap>();
                var records = csv.GetRecords<EndOfDay>().ToList();
            }
        }
    }
}
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

    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
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

    public sealed class ProductMap : CsvClassMap<Product>
    {
        public ProductMap()
        {
            Map(m => m.ProductId).Index(0);
            Map(m => m.ProductName).Index(1);
        }
    }

    class Program
    {
        static void Main()
        {
            //StreamReader csvReader = File.OpenText(@"..\..\Data\Test.csv");
            //using (var parser = new CsvParser(csvReader))
            //{
            //    while (true)
            //    {
            //        var row = parser.Read();
            //        if (row == null)
            //        {
            //            break;
            //        }
            //    }
            //}
            //using (var csv = new CsvReader(csvReader))
            //{
            //    csv.Configuration.RegisterClassMap<EndOfDayMap>();
            //    while (csv.Read())
            //    {
            //        var record = csv.GetRecord<EndOfDay>();
            //    }
            //}
            //using (var csv = new CsvReader(csvReader))
            //{
            //    csv.Configuration.RegisterClassMap<EndOfDayMap>();
            //    var records = csv.GetRecords<EndOfDay>().ToList();
            //}

            StreamReader csvReader = File.OpenText(@"..\..\Data\DL_BM_Products_Export.csv");
            using (var csv = new CsvReader(csvReader))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.RegisterClassMap<ProductMap>();
                var products = csv.GetRecords<Product>().ToList();
                var uniqueproducts = products.Distinct();
            }
        }
    }
}
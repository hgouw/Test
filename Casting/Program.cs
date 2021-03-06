﻿using System;

namespace Casting
{
    class Program
    {
        public class Asset
        {
            public string Name { get; set; }
        }
        public class House : Asset
        {
            public decimal Price { get; set; }
        }
        public class Stock : Asset
        {
            public long SharesOwned { get; set; }
        }

        static void Main(string[] args)
        {
            House house = new House { Name = "37 Robert Road, Cherrybrook", Price = 1000000 };
            Console.WriteLine("House -> ({0}, {1})", house.Name, house.Price);

            Stock stock = new Stock { Name = "Computershare", SharesOwned = 6000 };
            Console.WriteLine("Stock -> ({0}, {1})", stock.Name, stock.SharesOwned);

            Console.ReadLine();

            Asset asset = stock; // Implicitly upcast to a base class reference
            Console.WriteLine("(asset == stock) -> {0}", asset == stock);
            Console.WriteLine("Asset -> ({0})", asset.Name);

            Stock cpu = (Stock)asset; // Explicitly downcast to a subclass reference
            Console.WriteLine("Stock -> ({0}, {1})", cpu.Name, cpu.SharesOwned);

            House mansion;
            try
            {
                mansion = (House)asset; // Explicitly downcast to a subclass reference
            }
            catch (Exception ex)
            {
                Console.WriteLine("mansion = (House)asset -> ({0}", ex.Message);
            }

            mansion = asset as House; // If downcast fails resulting in a null instead of throwing an exception
            Console.WriteLine("mansion = asset as House -> ({0})", mansion == null ? "null" : "NOT null");

            Console.ReadLine();
        }
    }
}
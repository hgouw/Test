using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 }; // 4 elements
            a[1] = new int[3] { 9, 2, 7 }; // 3 elements
            Console.WriteLine(a[0].GetUpperBound(0)); // index of last element of a[0] is 3 (4-1)
            Console.WriteLine(a[1].GetUpperBound(0)); //index of last element of a[1] is 2 (3-1)
            Console.ReadLine();

            var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //arr.Mode();
            //arr.OrderBy(i => i);
            //arr.ToArray();
            //arr.Mean();
            //arr.Average();
        }
    }
}
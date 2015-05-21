using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string accounts = "Cheque,EveryDay,HighInterest,Saving";
            string[] accountsArray = accounts.Split(',');
            foreach (var account in accountsArray)
                Console.WriteLine(account);
            Console.ReadLine();

            int[][] a = new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 }; // 4 elements
            a[1] = new int[3] { 9, 2, 7 }; // 3 elements
            Console.WriteLine(a[0].GetUpperBound(0)); // index of last element of a[0] is 3
            Console.WriteLine(a[1].GetUpperBound(0)); //index of last element of a[1] is 2
            Console.ReadLine();
        }
    }
}
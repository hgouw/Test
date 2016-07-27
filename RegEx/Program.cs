using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldString = @"<p><a href=""https://www.legislation.gov.au/Details/C2011A00137"">Work Health and Safety Act 2011 (Cth)</a></p>";
            Console.WriteLine(oldString);
            var pattern = @"(?<start><a[^>]*)(?<end>>)";
            var replacement = @"${start} target=""_blank"" ${end}";
            var newString = Regex.Replace(oldString, pattern, replacement);
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
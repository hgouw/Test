using System;
using System.Collections.Generic;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main()
        {
            var employees = ProcessXML("Employees.xml");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.ReadLine();
        }

        private static List<Employee> ProcessXML(string xml)
        {
            var employees = new List<Employee>();
            XmlDocument doc = new XmlDocument();
            doc.Load(xml);
            foreach (XmlNode node in doc.DocumentElement)
            {
                employees.Add(new Employee { Name = node["Name"].InnerText, Location = node["Location"].InnerText });
            }
            return employees;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public override string ToString() => $"{Name} - {Location}";
    }
}
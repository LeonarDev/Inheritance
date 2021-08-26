using Inheritance.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee ${i} data:");
                Console.WriteLine("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeeList.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employeeList.Add(new Employee(name, hours, valuePerHour));
                }
            }
        
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

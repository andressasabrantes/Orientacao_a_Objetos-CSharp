using System;
using System.Globalization;

namespace RegisteredEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int idEmployee = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();

                Console.Write("Salary: ");
                double salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(idEmployee, nameEmployee, salaryEmployee));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee i in employees)
            {
                Console.WriteLine(i);
            }

        }
    }
}
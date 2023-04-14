using System;
using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level: (Junior/MidLevel/Senior): ");
            //Utiliza o enum WorkerLevel como o tipo do contrato
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instancia Department e Worker e já insere os parâmetros
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts this worker have? ");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                //Instancia HourContract já recebendo seus parâmetros
                HourContract contract = new HourContract(date, valuePerHour, hours);
                //Chama o método AddContract passando o parâmetro
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter the month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            //Divide a string monthAndYear para guardar as informações especificamente
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

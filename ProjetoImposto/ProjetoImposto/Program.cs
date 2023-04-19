using ProjetoImposto;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer {i} data:");
                Console.Write("Individual or Company? (i/c): ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anuallIncome = double.Parse(Console.ReadLine());

                if (type == 'i') 
                {                    
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anuallIncome, healthExpenditures));
                }
                else 
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anuallIncome, numberOfEmployees)); 
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(TaxPayer.name + ": $" + TaxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0.0;
            foreach(TaxPayer taxPayer in list) 
            {
                sum += taxPayer;                
            }
            
            Console.WriteLine("TOTAL PAXES: $" + sum);
        }
    }
}

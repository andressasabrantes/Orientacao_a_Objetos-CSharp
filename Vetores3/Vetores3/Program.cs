using System;
using System.Globalization;

namespace Vetores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler um número inteiro N e os dados(nome e preço) de N produtos.
            //Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.

            Console.WriteLine("How many products do you want to add? ");
            int n = int.Parse(Console.ReadLine());

            Product[] vetor = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Product { Name = name, Price = price };
            }


            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                sum += vetor[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"The Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
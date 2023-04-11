using System;

namespace Hostel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] student = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());                                   

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room number: ");
                int quarto = int.Parse(Console.ReadLine());
                student[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Occupied rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (student[i] != null)
                {
                    Console.WriteLine(i + ": " + student[i]);
                }
            }
        }
    }
}
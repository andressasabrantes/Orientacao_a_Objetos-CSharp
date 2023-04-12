using System;
using System.Collections.Generic;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>();

            List<string> minhaLista2 = new List<string> { "Maria", "Roberto", "João" };

            minhaLista.Add("João");
            minhaLista.Add("Anna");
            minhaLista.Add("Roberto");
            minhaLista.Add("Maria");
            minhaLista.Add("Andressa");
            minhaLista.Add("Andreza");
            minhaLista.Insert(3, "Mariana");
            minhaLista.Insert(4, "Jose");
            minhaLista.Add("Artur");

            foreach (string i in minhaLista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("List Count: " + minhaLista.Count);
            Console.WriteLine();

            foreach (string lista in minhaLista2)
            {
                Console.WriteLine(lista);
            }

            Console.WriteLine("List Count: " + minhaLista2.Count);
            Console.WriteLine();

            List<string> minhaLista3 = new List<string>();
            List<string> minhaLista4 = new List<string> { "Maria", "João", "Roberto" };

            foreach(string lista in minhaLista4)
            {
                minhaLista3.Add(lista);
            }
            
            foreach(string i in minhaLista3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("List Count: " + minhaLista3.Count);


            Console.WriteLine();
            string s1 = minhaLista.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' em minhaLista: " + s1);

            Console.WriteLine();
            string s2 = minhaLista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' em minhaLista: " + s2);

            Console.WriteLine();
            int pos1 = minhaLista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Find first index 'A': " + pos1);

            Console.WriteLine();
            int pos2 = minhaLista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Find last index 'A': " + pos2);


            Console.WriteLine();
            List<string> minhaLista5 = minhaLista.FindAll(x => x.Length == 5);
            foreach(string i in minhaLista5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
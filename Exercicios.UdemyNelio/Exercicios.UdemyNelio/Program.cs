using System;
using System.Globalization;

namespace Exercicios.UdemyNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Digite a idade dessa pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());


            Console.Write("Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade dessa pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());


            if (pessoa1.idade > pessoa2.idade) 
            {
                Console.WriteLine("Pessoa mais velha: {0}", pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", pessoa2.nome);
            }

        }
    }
}

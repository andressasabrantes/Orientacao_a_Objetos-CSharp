using System;
using System.Globalization;

namespace Exercicios.UdemyNelio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaTrimeste1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTrimeste2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTrimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Nome do aluno: {0}", aluno.Nome);
            Console.WriteLine($"NOTA FINAL = {0}", aluno.NotaFinal());
            Console.WriteLine(aluno.EstaAprovado());
        }
    }
}

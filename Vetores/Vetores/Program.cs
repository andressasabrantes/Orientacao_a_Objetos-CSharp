using System;
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            //Armazene as N alturas em um vetor. Em seguida, mostrar a altura médias dessas pessoas.


            Console.Write("Insira a quantidade de alturas que você deseja inserir: ");
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vetor[i];
            }

            double avg = sum / n;

            Console.WriteLine($"A altura média inserida é de: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
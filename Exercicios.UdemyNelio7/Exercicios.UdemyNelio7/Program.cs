using System;
using System.Globalization;

namespace Exercicios.UdemyNelio7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ConversorDeMoeda cotacao = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dólar? ");
            cotacao.CotacaoDoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            cotacao.QuantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write($"Valor a ser pago em reais: {cotacao.Dolares().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
using Exercicios.UdemyNelio4;
using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Exercicios.UdemyNelio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo R = new Retangulo();
            
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            double areaRetangulo = R.Area();
            Console.WriteLine("ÁREA = " + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture));

            double perimetroRetangulo = R.Perimetro();
            Console.WriteLine("PERÍMETRO = " + perimetroRetangulo.ToString("F2", CultureInfo.InvariantCulture));

            double diagonalRetangulo = R.Diagonal();
            Console.WriteLine("DIAGONAL = " + diagonalRetangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }   
    }
}

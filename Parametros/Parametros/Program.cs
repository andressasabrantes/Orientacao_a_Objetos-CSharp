using System;

namespace Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            int s3 = Calculator.Sum(2, 4, 3, 5, 6, 8, 10);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
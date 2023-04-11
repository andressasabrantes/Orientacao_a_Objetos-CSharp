using System;

namespace Parametros2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
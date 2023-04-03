using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        static double Area() {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

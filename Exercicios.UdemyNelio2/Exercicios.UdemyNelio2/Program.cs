using System;
using System.Globalization;

namespace Exercicios.UdemyNelio2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Funcionario funcionario1, funcionario2;
            
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Digite o salário desse funcionário: ");
            funcionario1.salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do primeiro funcionário: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Digite o salário desse funcionário: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (funcionario1.salario + funcionario2.salario) / 2.0;
            Console.WriteLine("Salário médio = {0}", salarioMedio);

        }
    }
}

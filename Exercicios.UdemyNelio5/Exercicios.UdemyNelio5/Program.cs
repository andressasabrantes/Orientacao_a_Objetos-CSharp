using System;
using System.Globalization;

namespace Exercicios.UdemyNelio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {f.Nome}, ${f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagemSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            porcentagemSalario = f.AumentarSalario(porcentagemSalario);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f.Nome}, ${porcentagemSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
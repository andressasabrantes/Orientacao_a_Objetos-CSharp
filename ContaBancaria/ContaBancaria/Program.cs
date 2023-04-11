using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seus dados abaixo");
            Console.WriteLine();

            Console.Write("Entre o número da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular: ");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            char opcao = char.Parse(Console.ReadLine());
            Console.WriteLine();

            ContaBancaria conta;

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta ");
            conta.MostrarDados();

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados ");
            conta.MostrarDados();

            Console.WriteLine();
            Console.WriteLine("Digite um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados ");
            conta.MostrarDados();
        }
    }
}

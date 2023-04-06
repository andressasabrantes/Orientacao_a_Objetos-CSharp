using System;
using System.Globalization;


namespace ContaBancaria
{
    internal class ContaBancaria
    {
        private int _numeroDaConta;
        private string _nomeTitular;
        private double _saldo;
        
     
        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial = 0)
        {
            _numeroDaConta = numeroConta;
            _nomeTitular = nomeTitular;
            _saldo = depositoInicial;
        }

        public int NumeroConta
        {
            get { return _numeroDaConta; }
        }

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }

        public void Depositar(double valorDeposito)
        {
            _saldo += valorDeposito;
        }
        
        public void Sacar(double valor)
        {            
            if (valor + 5 > _saldo)
            {
                Console.WriteLine("Erro ao sacar: Saldo Insuficiente!");
            }
            else
            {
                _saldo -= valor + 5;
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Número da conta: {_numeroDaConta}");
            Console.WriteLine($"Nome do titular: {_nomeTitular}");
            Console.WriteLine("Saldo: R$ " + _saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

    }

}

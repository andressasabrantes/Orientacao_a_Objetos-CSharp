using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.UdemyNelio5
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            double salarioAumento = (porcentagem / 100) * SalarioBruto;
            salarioAumento += SalarioLiquido();
            return salarioAumento;
        }
    }
}

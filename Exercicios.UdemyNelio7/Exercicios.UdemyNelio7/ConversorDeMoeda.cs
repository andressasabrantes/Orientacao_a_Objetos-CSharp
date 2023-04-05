using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.UdemyNelio7
{
    internal class ConversorDeMoeda
    {
        public double CotacaoDoDia;
        public double QuantidadeDolar;


        public double Dolares()
        {
            return CotacaoDoDia * QuantidadeDolar;
        }


    }
}

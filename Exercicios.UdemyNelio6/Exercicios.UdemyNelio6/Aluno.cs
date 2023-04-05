using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.UdemyNelio6
{
    internal class Aluno
    {
        public string Nome;
        public double NotaTrimeste1;
        public double NotaTrimeste2;
        public double NotaTrimestre3;

        public double NotaFinal() {            
            return NotaTrimeste1 + NotaTrimeste2 + NotaTrimestre3;
        }

        public string EstaAprovado() {

            if (NotaTrimeste1 + NotaTrimeste2 + NotaTrimestre3 >= 60) {
                return "Está APROVADO!";
            }
            else {
                double pontuacaoFaltante = (NotaTrimeste1 + NotaTrimeste2 + NotaTrimestre3) - 60;
                Console.WriteLine($"Faltaram: {0}", pontuacaoFaltante);                
                return "Está REPROVADO!";
            }
        }
    }
}

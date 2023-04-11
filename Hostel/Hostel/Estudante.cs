using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hostel
{
    internal class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }    
}

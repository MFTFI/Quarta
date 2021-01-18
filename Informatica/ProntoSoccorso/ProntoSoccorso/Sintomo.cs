using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSoccorso
{
    public class Sintomo
    {
        public string Nome { get; private set; }
        public Gravita Rischio { get; private set; }

        public Sintomo(string nome, Gravita rischio)
        {
            Nome = nome;
            Rischio = rischio;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Classe { get; set; }

        public Studente(string nome, string cognome, string classe)
        {
            Nome = nome;
            Cognome = cognome;
            Classe = classe;
        }
    }
}

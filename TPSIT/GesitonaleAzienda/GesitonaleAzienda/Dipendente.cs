using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesitonaleAzienda
{
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string LuogoDiNascita { get; set; }
        public DateTime DataDiNascita { get; set; }
        //[DisplayName("Contratti")]
        public List<Contratto> Contratti { get; set; } = new List<Contratto>();

        public Dipendente(string nome, string cognome, string luogoDiNascita, DateTime dataDiNascita, List<Contratto> contratti)
        {
            Nome = nome;
            Cognome = cognome;
            LuogoDiNascita = luogoDiNascita;
            DataDiNascita = dataDiNascita;
            Contratti = contratti;
        }
        public Dipendente(string nome, string cognome, string luogoDiNascita, DateTime dataDiNascita, Contratto contratto = null)
        {
            Nome = nome;
            Cognome = cognome;
            LuogoDiNascita = luogoDiNascita;
            DataDiNascita = dataDiNascita;
            if (contratto != null)
                Contratti.Add(contratto);
        }
    }
}

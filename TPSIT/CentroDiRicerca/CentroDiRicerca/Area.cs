using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiRicerca
{
    public class Area
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Posizione { get; set; }

        public List<Ricercatore> Ricercatori { get; set; }=new List<Ricercatore>();
        public RicercatoreSenior Responsabile { get; set; }
        public List<Progetto> Progetti { get; set; }=new List<Progetto>();

        public Area(string nome, string indirizzo, string posizione, RicercatoreSenior responsabile)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Posizione = posizione;
            Responsabile = responsabile;
        }

        public int GetNumProgettiAttivi()
        {
            throw new NotImplementedException();
        }

        public int GetNumRicercatori()
        {
            throw new NotImplementedException();
        }
    }
}

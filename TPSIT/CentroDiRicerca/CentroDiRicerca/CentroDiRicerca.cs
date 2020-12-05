using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiRicerca
{
    public class CentroDiRicerca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Posizione { get; set; }
        public int NAree { get => Aree.Count; }

        public List<Area> Aree { get; set; } = new List<Area>();

        public CentroDiRicerca(string nome, string indirizzo, string posizione, int nAree)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Posizione = posizione;
        }

        public int GetNumProgetti()
        {
            throw new NotImplementedException();
        }

        public int GetNumAree()
        {
            throw new NotImplementedException();
        }

        public int GetNumRicercatori()
        {
            throw new NotImplementedException();
        }
    }
}

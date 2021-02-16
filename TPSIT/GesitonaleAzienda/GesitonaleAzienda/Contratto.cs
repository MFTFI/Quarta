using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesitonaleAzienda
{
    public class Contratto
    {
        public DateTime DataAttivita { get; set; }
        public float OreAttivita { get; set; }
        public string Descrizione { get; set; }

        public Contratto(DateTime dataAttivita, float oreAttivita, string descrizione)
        {
            DataAttivita = dataAttivita;
            OreAttivita = oreAttivita;
            Descrizione = descrizione;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircoloTennis
{
    public class Prenotazione
    {
        public DateTime OrarioPrenotazione { get; set; }
        public float OrarioFinale { get; set; }
        public int NumPersone { get; set; }
        public float Costo { get => CalcolaPrezzo(); set { } }

        public Prenotazione(DateTime orarioPrenotazione, float orarioFinale, int numPersone, float costo)
        {
            OrarioPrenotazione = orarioPrenotazione;
            OrarioFinale = orarioFinale;
            NumPersone = numPersone;
            Costo = costo;
        }

        private float CalcolaPrezzo()
        {
            return 0.0f;
        }
    }
}

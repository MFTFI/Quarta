using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircoloTennis
{
    public class Campo
    {
        public List<Prenotazione> Prenotazioni { get; set; } = new List<Prenotazione>();
        public string Codice { get; set; }
        public float OrarioApertura { get; set; }
        public float OrarioChiusura { get; set; }

        public Campo(string codice, float orarioApertura, float orarioChiusura)
        {
            Codice = codice;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
        }
    }
}

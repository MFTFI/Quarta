using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircoloTennis
{
    public class Circolo
    {
        public List<Campo> Campi { get; set; } = new List<Campo>();
        public string Indirizzo { get; set; }
        public List<Socio> Soci { get; set; } = new List<Socio>();
        public List<Utente> Utenti { get; set; } = new List<Utente>();
        public Dictionary<Utente, Prenotazione> PrenotazioniAttive { get; set; } = new Dictionary<Utente, Prenotazione>();
        public DateTime GiornoPrenotazioneSoci { get; set; }

        public void AggiungiPrenotazione<T>(T prenotatore)
        {
            if(typeof(Utente) == typeof(T)) //prenotazione Utente
            {
                (prenotatore as Utente).Paga(69.0f);
            }
            else if(typeof(Socio) == typeof(T)) //prenotazione socio
            {
                (prenotatore as Socio).Paga(420.0f);
            }
            else
            {

            }
        }

        public void Disdici(Prenotazione prenotazione)
        {
            TimeSpan diff = DateTime.Now - prenotazione.OrarioPrenotazione;
            if (diff.Hours <= 24)
            {
                //rimborso entro la giornata
            }
            else
            {
                //!rimborso entro la giornata
            }
        }
    }
}

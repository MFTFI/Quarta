using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiRicerca
{
    public class Progetto
    {
        public string Nome { get; set; }
        public string Codice { get; set; }
        public int OreLavoro { get; set; }
        public Team Team { get; set; }
        public RicercatoreSenior Leader { get; set; }
        public List<RicercatoreJunior> Ricercatori { get; set; }=new List<RicercatoreJunior>();

        public Progetto(string nome, string codice, int oreLavoro, Team team, RicercatoreSenior leader)
        {
            Nome = nome;
            Codice = codice;
            OreLavoro = oreLavoro;
            Team = team;
            Leader = leader;
        }

        public float CalcolaCosto()
        {
            throw new NotImplementedException();
        }

        public bool TerminaProgetto()
        {
            throw new NotImplementedException();
        }
    }
}

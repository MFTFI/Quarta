using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiRicerca
{
    public class Team
    {
        public string Nome { get; set; }
        public string Codice { get; set; }

        public Team(string nome, string codice)
        {
            Nome = nome;
            Codice = codice;
        }

        public string InfoTeam()
        {
            throw  new NotImplementedException();
        }

        public void AddRicercatore(RicercatoreJunior ricercatore)
        {
            throw new NotImplementedException();
        }

        public void DeleteRicercatore(RicercatoreJunior ricercatore)
        {
            throw new NotImplementedException();
        }

        public void CambiaResponsabile(RicercatoreSenior responsabile)
        {
            throw new NotImplementedException();
        }
    }
}

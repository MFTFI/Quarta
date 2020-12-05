using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiRicerca
{
    public class Ricercatore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public float Stipendio { get; set; }
        public string Grado { get; set; }

        public Ricercatore(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, float stipendio, string grado)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            CodiceFiscale = codiceFiscale;
            Stipendio = stipendio;
            Grado = grado;
        }

        public void AumentaStipendio(float aumnto)
        {
            throw new NotImplementedException();
        }
    }

    public class RicercatoreSenior : Ricercatore
    {
        public List<string> Pubblicazioni { get; set; } = new List<string>();
        public float BonusStipendio { get; set; }

        public RicercatoreSenior(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, float stipendio, string grado, List<string> pubblicazioni, float bonusStipendio)
            :  base(nome, cognome, dataDiNascita, codiceFiscale, stipendio, grado)
        {
            Pubblicazioni = pubblicazioni;
            BonusStipendio = bonusStipendio;
        }
    }

    public class RicercatoreJunior : Ricercatore
    {
        public int AnniTirocinio { get; set; }

        public RicercatoreJunior(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, float stipendio, string grado, int anniTirocinio)
            :  base(nome, cognome, dataDiNascita, codiceFiscale, stipendio, grado)
        {
            AnniTirocinio = anniTirocinio;
        }

        public int TotaleAnniTirocinio()
        {
            throw new NotImplementedException();
        }
    }
}

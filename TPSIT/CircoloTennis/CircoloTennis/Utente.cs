using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircoloTennis
{
    public enum FasceOrario
    {
        Mattina,
        Pomeriggio,
        Sera
    }

    public enum Mano
    {
        Destro,
        Mancino,
        Ambidestro
    }

    public class Utente
    {
        public float Credito { get; set; } = 100.0f;
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroTelefono { get; set; }
        public FasceOrario OrarioPreferito { get; set; }
        public Mano ManoPreferita { get; set; }

        public Utente(string mail, string password, string nome, string cognome, string numeroTelefono, FasceOrario orarioPreferito, Mano manoPreferita)
        {
            Mail = mail;
            Password = password;
            Nome = nome;
            Cognome = cognome;
            NumeroTelefono = numeroTelefono;
            OrarioPreferito = orarioPreferito;
            ManoPreferita = manoPreferita;
        }

        public void Paga(float costo) { }
    }

    public class Socio : Utente
    {
        public float QuotaAbbonamento { get; set; }

        public Socio(string mail, string password, string nome, string cognome, string numeroTelefono, FasceOrario orarioPreferito, Mano manoPreferita, float quotaAbbonamento)
            : base(mail, password, nome, cognome, numeroTelefono, orarioPreferito, manoPreferita)
        {
            QuotaAbbonamento = quotaAbbonamento;
        }
    }
}

using System.Collections.Generic;

namespace Marchini.Claudio.Regioni
{
    public class Provincia
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public Provincia(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public static List<Provincia> operator +(List<Provincia> sinistra, Provincia destra)
        {
            sinistra.Add(destra);
            return sinistra;
        }
    }
}
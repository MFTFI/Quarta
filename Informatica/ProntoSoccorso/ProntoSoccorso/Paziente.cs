using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSoccorso
{
    public enum Gravita
    {
        Bianco,
        Verde,
        Giallo,
        Rosso
    }

    public class Paziente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public List<Sintomo> Sintomi { get; private set; } = new List<Sintomo>();
        public Gravita Gravita { get => OttientiCodiceGravita(); private set { } }
        public Paziente(string nome, string cognome, List<Sintomo> sintomi)
        {
            Nome = nome;
            Cognome = cognome;
            Sintomi = sintomi;
        }

        /// <summary>
        /// La gravità di un paziente viene calcolata facendo la media della gravità di tutte le sue malattie
        /// </summary>
        /// <returns></returns>
        public Gravita OttientiCodiceGravita()
        {
            int tot = 0;
            foreach (var sintomo in Sintomi)
                tot += (int)sintomo.Rischio;

            return (Gravita)(tot / Sintomi.Count);
        }
    }
}
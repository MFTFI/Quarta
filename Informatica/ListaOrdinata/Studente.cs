using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdinata
{
    class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public List<int> Voti { get; private set; } = new List<int>();
        public float Media { get 
            {
                int media = 0;
                foreach (int voto in Voti)
                    media += voto;
                return media / (float)Voti.Count;
            }}

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public void AggiungiVoto(int voto) => Voti.Add(voto);
        public void EliminaVoto(int voto) => Voti.Remove(voto);
    }
}

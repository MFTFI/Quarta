using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdinata
{
    class ListaStudenti
    {
        public Studente this[int key]
        {
            get => lista[key];
            set => lista[key] = value;
        }

        public ListaStudenti() { }

        public void AggiungiElemento(Studente elemento) => lista.Add(elemento);
        public void EliminaElemento(Studente elemento) => lista.Remove(elemento);

        public List<Studente> Ordina(bool inverso = false)
        {
            Studente temp;
            for (int j = 0; j <= lista.Count - 2; j++)
                for (int i = 0; i <= lista.Count - 2; i++)
                    if (lista[i].Media > lista[i + 1].Media)
                    {
                        temp = lista[i + 1];
                        lista[i + 1] = lista[i];
                        lista[i] = temp;
                    }
            if (inverso)
                lista.Reverse();
            return lista;
        }

        private List<Studente> lista = new List<Studente>();
    }
}

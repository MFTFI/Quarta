using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdinata
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaStudenti lista = new ListaStudenti();

            lista.AggiungiElemento(new Studente("Alessio", "Giorgi"));
            lista.AggiungiElemento(new Studente("Antonio", "Padani"));
            lista.AggiungiElemento(new Studente("Arco", "Rossi"));

            lista[0].AggiungiVoto(7);
            lista[0].AggiungiVoto(8);

            lista[1].AggiungiVoto(8);
            lista[1].AggiungiVoto(5);

            lista[2].AggiungiVoto(3);
            lista[2].AggiungiVoto(6);
            lista[2].AggiungiVoto(5);

            foreach (var tmp in lista.Ordina())
                Console.WriteLine($"Alunno: {tmp.Cognome} | Media: {tmp.Media}");

            Console.ReadLine();
        }
    }
}

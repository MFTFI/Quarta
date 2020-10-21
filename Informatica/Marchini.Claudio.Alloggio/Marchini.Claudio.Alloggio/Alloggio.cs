using System;
using System.Collections.Generic;
using System.Text;

namespace Marchini.Claudio.Alloggio
{
    public class Alloggio
    {
        public int Codice { get; private set; }
        public int NumPersone { get; private set; }
        public double MetriQuadri { get; private set; }

        public Alloggio(int codice, int numPersone, double metriQuadri)
        {
            Codice = codice;
            NumPersone = numPersone;
            MetriQuadri = metriQuadri;
        }

        public double CostoAcqua(double quantita)
        {
            return quantita * NumPersone;
        }

        public double Valore(double valore)
        {
            return valore * MetriQuadri;
        }

        public virtual double Densita()
        {
            return MetriQuadri / (double)NumPersone;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Marchini.Claudio.Alloggio
{
    public class Villa : Alloggio
    {
        public double Giardino { get; private set; }

        public Villa(int codice, int numPersone, double metriQuadri, double giardino)
            : base(codice, numPersone, metriQuadri)
        {
            Giardino = giardino;
        }

        public double Valore(double valore1, double valore2)
        {
            return Valore(valore1) + valore2 * Giardino;
        }

        public override double Densita()
        {
            return (MetriQuadri + Giardino) / (double)NumPersone;
        }
    }
}

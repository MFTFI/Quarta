using System;
using System.Collections.Generic;
using System.Text;

namespace Quadrilatero
{
    public class QuadrilateroClass
    {
        private float lato1, lato2;
        public QuadrilateroClass(float lato)
        {
            lato1 = lato2 = lato;
        }

        public QuadrilateroClass(float lato1, float lato2)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
        }

        public float CalcolaPerimetro()
        {
            return (lato1 + lato2) * 2.0f;
        }

        public float CalcolaArea()
        {
            return lato1 * lato2;
        }
    }
}

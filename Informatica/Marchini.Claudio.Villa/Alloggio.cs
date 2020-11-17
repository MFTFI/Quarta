namespace Marchini.Claudio.Villa
{
    public class Alloggio
    {
        public int Codice { get; private set; }
        public int NumPersone { get; private set; }
        public float MetriQuadri { get; private set; }
        public float CostoAcqua { get => CalcolaAcqua(costoAcqua); private set { costoAcqua = value; } }

        public Alloggio(int codice, int numPersone, float metriQuadri, float costoAcqua)
        {
            Codice = codice;
            NumPersone = numPersone;
            MetriQuadri = metriQuadri;
            CostoAcqua = costoAcqua;
        }

        public float CalcolaAcqua(float costo)
        {
            return costo * NumPersone;
        }
        public virtual float Densita()
        {
            return MetriQuadri / NumPersone;
        }

        private float costoAcqua;
    }
}
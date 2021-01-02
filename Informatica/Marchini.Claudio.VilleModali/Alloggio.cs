using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marchini.Claudio.VilleModali
{
    public class Alloggio
    {
        public int Id { get; private set; }
        public int NumeroPersone { get; private set; }
        public float Metri { get; private set; }
        public float CostoAcqua { get; private set; }

        public Alloggio(int id, int numeroPersone, float metri, float costoAcqua)
        {
            Id = id;
            NumeroPersone = numeroPersone;
            Metri = metri;
            CostoAcqua = costoAcqua;
        }
    }

    public class Villa : Alloggio
    {
        public float MetriGiardino { get; private set; }

        public Villa(int id, int numeroPersone, float metri, float costoAcqua, float metriGiardino)
        : base(id, numeroPersone, metri, costoAcqua)
        {
            MetriGiardino = metriGiardino;
        }
    }
}

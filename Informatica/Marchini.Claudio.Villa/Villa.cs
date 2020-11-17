using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Marchini.Claudio.Villa
{
    public class Villa : Alloggio
    {
        public float Giardino { get; private set; }  //dimensione in metri del giardino

        public Villa(int codice, int numPersone, float metriQuadri, float costoAcqua, float giardino) //inizializzo le variabili della classe
            :  base(codice, numPersone, metriQuadri, costoAcqua)
        {
            Giardino = giardino;
        }

        public static List<Villa> CaricaVille(string fileName) //metodo che crea un lista di ville da un file csv
        {
            List<Villa> ville = new List<Villa>();
            int posId = 0, posNumPersone = 0, posMetri = 0, posCostoAcqua = 0, posMetriGiardino = 0; //contengono le posizioni di ogni variabile nella linea

            using (var sr = new StreamReader(fileName))
            {
                string[] data = sr.ReadLine().Trim().Split(','); //divido la prima linea
                for (int i = 0; i < data.Length; i++)
                {
                    switch (data[i]) //in base alla formattazione della prima linea capisco come trattare i dati
                    {
                        case "id":
                            posId = i;
                            break;
                        case "numeroPersone":
                            posNumPersone = i;
                            break;
                        case "metri":
                            posMetri = i;
                            break;
                        case "costoUnitarioAcqua":
                            posCostoAcqua = i;
                            break;
                        case "metriGiardino":
                            posMetriGiardino = i;
                            break;
                        default:
                            throw new Exception("Formato del file non supportato!"); //se la formattazione è sbagliata esco dal programma
                    }
                }
                while(!sr.EndOfStream) // leggo le restanti linee con i dati
                {
                    data = sr.ReadLine().Split(',');

                    int codice, numPersone; //converto codice e numeroDiPersone in intero
                    int.TryParse(data[posId], out codice);
                    int.TryParse(data[posNumPersone], out numPersone);

                    var nfi = new NumberFormatInfo(); //classe usata per specificare che il separatore è "." invece di ",", la classe eredita dall`interfaccia IFormatProvider
                    nfi.NumberDecimalSeparator = ".";
                    float metri, costoAcqua, giardino; //converto metri costoAcqua e giardino in float
                    float.TryParse(data[posMetri], NumberStyles.Any, nfi, out metri); //uso il formato specificato
                    float.TryParse(data[posCostoAcqua], NumberStyles.Any, nfi, out costoAcqua);
                    float.TryParse(data[posMetriGiardino], NumberStyles.Any, nfi, out giardino);

                    ville.Add(new Villa(codice, numPersone, metri, costoAcqua, giardino)); //aggiungo la villa alla lista da restituire
                }
            }
            return ville;
        }

        public override float Densita()
        {
            return (MetriQuadri + Giardino) / NumPersone;
        }
    }
}

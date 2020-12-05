using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Media;
using System.IO;
using System.Globalization;

namespace Auto
{
    public class Automobile
    {
        public string Modello { get; private set; }
        public int Cilindrata { get; private set; }
        public Color Colore { get; private set; }
        public float Prezzo { get; private set; }

        public Automobile(string modello, int cilindrata, Color colore, float prezzo)
        {
            Modello = modello;
            Cilindrata = cilindrata;
            Colore = colore;
            Prezzo = prezzo;
        }

        public static bool CaricaDaFile<T>(string file, out List<T> auto)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            auto = new List<T>();
            try
            {
                using (var sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] dati = sr.ReadLine().Trim().Split(',');

                        if (dati.Length >= 4)
                        {
                            string modello = dati[0];

                            int cilindrata;
                            int.TryParse(dati[1], out cilindrata);

                            byte[] colori = new byte[3];
                            for (int i = 0; i < colori.Length; i++)
                            {
                                byte.TryParse(string.Concat(dati[2][i * 3], dati[2][(i * 3) + 1], dati[2][(i * 3) + 2]), out colori[i]);
                            }
                            Color colore = Color.FromRgb(colori[0], colori[1], colori[2]);

                            float prezzo;
                            float.TryParse(dati[3], NumberStyles.Float, nfi, out prezzo);

                            if(dati.Length == 4 && typeof(T) == typeof(Automobile))
                                auto.Add((T)Activator.CreateInstance(typeof(T), new object[] { modello, cilindrata, colore, prezzo }));

                            else if(dati.Length == 5 && typeof(T) == typeof(AutoUsata))
                            {
                                float kmUsati;
                                float.TryParse(dati[4], NumberStyles.Float, nfi, out kmUsati);
                                auto.Add((T)Activator.CreateInstance(typeof(T), new object[] { modello, cilindrata, colore, prezzo, kmUsati }));     
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                auto = null;
                return false;
            }
            return true;
        }
    }

    public class AutoUsata :  Automobile
    {
        public float KmUsati { get; private set; }

        public AutoUsata(string modello, int cilindrata, Color colore, float prezzo, float kmUsati) 
            : base(modello, cilindrata, colore, prezzo)
        {
            KmUsati = kmUsati;
        }

        public AutoUsata(string modello, int cilindrata, Color colore, float prezzo)
            : base(modello, cilindrata, colore, prezzo)
        {

        }
    }
}

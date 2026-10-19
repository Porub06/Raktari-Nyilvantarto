using System;
using System.Collections.Generic;
using System.Text;

namespace Raktari_Nyilvantarto
{
    internal class Termek
    {
        public string Cikkszam { get; set; }
        protected int alapar;
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value <= 0)
                {
                    alapar = 1000;
                }
                else
                {
                    value = alapar;
                }
            }

        }
        private static int osszesTermekSzama;
        public static int OsszesTermekekSzama { get { return osszesTermekSzama; } }

        //Konstruktor

        public Termek(string cikkszam, int alapar)
        {
            Cikkszam = cikkszam;
            Alapar = alapar;
            osszesTermekSzama++;

        }

        //Metódusok

        public virtual int ErtekSzamitas(int darabszam)
        {
            return Alapar * darabszam;
        }

        public override string ToString()
        {
            return $"Termék{Cikkszam} | Egységár: {Alapar} Ft ";
        }


    }

}
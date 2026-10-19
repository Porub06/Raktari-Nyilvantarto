using System;
using System.Collections.Generic;
using System.Text;

namespace Raktari_Nyilvantarto
{
    internal class TartosTermek : Termek
    {
        public int GaranciaEvek { get; set; }

        //Konstruktor

        public TartosTermek(string cikkszam, int alapar,int garanciaevek) : base(cikkszam, alapar)
        {
            GaranciaEvek = garanciaevek;
        }

        public override int ErtekSzamitas(int darabszam)
        {
            return base.ErtekSzamitas(darabszam) + (GaranciaEvek * 500 * darabszam);
        }

        public override string ToString()
        {
            return base.ToString() + $"| Garancia: {GaranciaEvek} év";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using _3_Szulo;

namespace Szulo_osztaly
{
    class Szulo : Szemely,IEgyForeJutoJovedelem
    {
        private string vezeteknev;
        private string keresztnev;
        private DateTime szuletesIdeje;
        private double magassag;
        private long fizetes;
        private bool hazas;
        private int gyerekekSzama;

        public Szulo(string vezeteknev, string keresztnev, DateTime szuletesIdeje, double magassag, long fizetes, bool hazas, int gyerekekSzama) : base(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.magassag = magassag;
            this.fizetes = fizetes;
            this.hazas = hazas;
            this.gyerekekSzama = gyerekekSzama;
        }
        
        public double Magassag
        {
            get { return magassag; }
        }

        public double EgyForeJutoJovedelem()
        {
            int x = 0;
            if (hazas)
            {
                x = 2;
            }
            else
            {
                x = 1;
            }

            return (fizetes / (gyerekekSzama + x));
        }

        public override string ToString()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Magasság: " + Magassag + " Egy főre jutó jövedelem: " + EgyForeJutoJovedelem();
        }
    }
}
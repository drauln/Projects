using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    public class Szemely
    {
        public string keresztnev;
        private DateTime szuletesIdeje;
        public long fizetes;
        public double magassag;
        public bool hazas;

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
        }

        public Szemely() { }

        private string vezeteknev; //propfull

        public string Vezeteknev
        {
            get
            {
                return vezeteknev;
            }
        }

        public string Keresztnev
        {
            get { return keresztnev; }
            set { keresztnev = value; }
        }

        public long Fizetes
        {
            get { return fizetes; }
            set { fizetes = value; }
        }

        public double Magassag
        {
            get { return magassag; }
            set { magassag = value; }
        }

        public bool Hazas
        {
            get { return hazas; }
        }

        public void Novel(double ertek)
        {
            fizetes = Convert.ToInt32(fizetes * (ertek / 100 + 1));
        }

        public int NagyobbE(Szemely masik)
        {
            if (fizetes == masik.fizetes)
            {
                return 0;
            }
            else
            {
                if (fizetes > masik.fizetes)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Fizetés: " + Fizetes + " Magasság: " + Magassag;
        }
    }
}
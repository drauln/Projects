using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    public class Szemely
    {
        private string keresztnev;
        private DateTime szuletesIdeje;
        private long fizetes;
        private double magassag;
        private bool hazas;

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
        }
        
        private string vezeteknev; //propfull

        public string Vezeteknev
        {
            get
            {
                return vezeteknev;
            }
            set
            {
                Console.WriteLine("Az értéket megváltoztatták.");
                vezeteknev = value;
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
        
        public void Novel(int ertek)
        {
            fizetes += ertek;
        }
        
        public bool FizetesIntervalluma(int minimum,int maximum)
        {
            if (minimum < fizetes && fizetes < maximum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long Ado(int szazalek)
        {
            return (fizetes * szazalek / 100);
        }

        public static bool NagyobbE(long egyik,long masik)
        {
            if (egyik>masik)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Fizetés: " + Fizetes + " Magasság: " + Magassag;
        }
    }
}

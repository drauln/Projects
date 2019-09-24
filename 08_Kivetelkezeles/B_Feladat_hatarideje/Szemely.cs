using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Szemely
    {
        private string keresztnev;
        private DateTime szuletesIdeje;
        private long fizetes;
        private double magassag;
        private bool hazas;
        private string feladat;
        private DateTime hatarIdo;

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas, string feladat, DateTime hatarIdo)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
            this.feladat = feladat;
            this.hatarIdo = hatarIdo;
        }
        
        public bool KesobbiHatarIdo(Szemely masik)
        {
            if (hatarIdo.CompareTo(masik.hatarIdo) == 1)
            {
                return true;
            }
            else return false;
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
        
        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Fizetés: " + Fizetes + " Magasság: " + Magassag + " Határidő: " + hatarIdo;
        }
    }
}

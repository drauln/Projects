using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Szemely:IComparable
    {
        public string vezeteknev;
        public string keresztnev;
        public DateTime szuletesIdeje;
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

        public long Fizetes
        {
            get { return fizetes; }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Szemely masik = obj as Szemely;
            if (masik != null)
            {
                return Fizetes.CompareTo(masik.Fizetes);
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Fizetés: " + fizetes + " Magasság: " + magassag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Szemely
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

        public string Kiir0()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev;
        }

        public string Kiir1()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Születésideje: " + szuletesIdeje;
        }

        public string Kiir2()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Születésideje: " + szuletesIdeje + " Fizetés: " + fizetes;
        }

        public string Kiir3()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Születésideje: " + szuletesIdeje + " Fizetés: " + fizetes + " Magasság: " + magassag;
        }

        public string Kiir4()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Születésideje: " + szuletesIdeje + " Fizetés: " + fizetes + " Magasság: " + magassag + " Házas: " + hazas;
        }

        public override string ToString()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Fizetés: " + fizetes + " Magasság: " + magassag;
        }
    }
}

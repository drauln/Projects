using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    public class Szemely
    {
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        private DateTime SzuletesIdeje { get; set; }
        public long Fizetes { get; set; }
        public double Magassag { get; set; }
        public bool Hazas { get; set; }

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            SzuletesIdeje = szuletesIdeje;
            Fizetes = fizetes;
            Magassag = magassag;
            Hazas = hazas;
        }

        public Szemely() { }
        
        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Fizetés: " + Fizetes + " Magasság: " + Magassag;
        }
    }
}

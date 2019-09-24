using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Szemely
    {
        private string vezeteknev;
        private string keresztnev;
        private DateTime szuletesIdeje;
        private long fizetes;
        private double magassag;
        private bool hazas;

        string chars = "abcdefghijklmnopqrstuvwxyz";
        Random rnd = new Random();

        public Szemely()
        {
            System.Threading.Thread.Sleep(5);
            vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)]; System.Threading.Thread.Sleep(5);
            keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)]; System.Threading.Thread.Sleep(5);
            szuletesIdeje = DateTime.Now;
            fizetes = rnd.Next(150000,250001);
            magassag = rnd.Next(15,23)/10;
            hazas = false;
        }
        
        public string Nev
        {
            get { return vezeteknev + " " + keresztnev; }
        }

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
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Fizetés: " + Fizetes + " Magasság: " + Magassag;
        }
    }
}

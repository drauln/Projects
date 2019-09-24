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

        public Szemely()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            int ev = rnd.Next(1940, 2011);
            
            int honap = rnd.Next(1, 13);
            
            int nap = rnd.Next(1, 28);
            szuletesIdeje = new DateTime(ev, honap, nap);
            
            vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];
            
            keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];
            fizetes = rnd.Next(60000,200001);
            magassag = Math.Round((double)rnd.Next(14, 24) / 10,2);
            if (rnd.Next(0, 2) == 0)
            {
                hazas = false;
            }
            else
            {
                hazas = true;
            }
            System.Threading.Thread.Sleep(50);//Random értékek miatt szükséges a késleltetés
        }

        public void Novel(int ertek)
        {
            fizetes += ertek;
        }
        
        public override string ToString()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Fizetés: " + fizetes + " Magasság: " + magassag+ " idő: " + szuletesIdeje;
        }
    }
}

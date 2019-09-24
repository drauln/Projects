using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Szemely
    {
        string vezeteknev;
        string keresztnev;
        DateTime szuletesIdeje;
        long fizetes;
        double magassag;
        bool hazas;
        
        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
        }

        public override string ToString()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Fizetés: " + fizetes + " Magasság: " + magassag;
        }

        public DateTime SzuletesIdeje
        {
            get { return szuletesIdeje; }
        }

        public bool Hazas
        {
            get { return hazas; }
        }

        public long Fizetes
        {
            get { return fizetes; }
        }

        public double Magassag
        {
            get { return magassag; }
        }
        
        public static string NevGenerator(string szoveg, int karakterSzam)
        {
            string generalt = "";
            Random rnd = new Random();

            for (int i = 0; i < karakterSzam; i++)
            {
                if (i == 0)
                {
                    generalt += szoveg[rnd.Next(0, szoveg.Length)].ToString().ToUpper();
                }
                else
                {
                    generalt += szoveg[rnd.Next(0, szoveg.Length)].ToString();
                    System.Threading.Thread.Sleep(5);
                }
            }
            
            return generalt;
        }

        public static int Index(Szemely[] valami,int elem)
        {
            int min = 0;
            int index;
            index = 0;
            min = valami[0].SzuletesIdeje.Year;
            for (int i = 0; i < elem; i++)
            {
                if (valami[i].SzuletesIdeje.Year < min)
                {
                    min = valami[i].SzuletesIdeje.Year;
                    index = i;
                }
            }
            return index;
        }

    }
}

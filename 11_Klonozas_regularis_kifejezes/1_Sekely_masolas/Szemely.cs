using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    public class HaviFizetes
    {
        public long Fizetes { get; set; }

        public HaviFizetes(long Fizetes)
        {
            this.Fizetes = Fizetes;
        }
    }
    class Szemely
    {
        string vezeteknev;
        string keresztnev;
        DateTime szuletesIdeje;
        public HaviFizetes HaviFizetes { get; set; }
        double magassag;
        bool hazas;
        
        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.HaviFizetes = new HaviFizetes(fizetes);
            this.magassag = magassag;
            this.hazas = hazas;
        }
        
        public Szemely SekelyMasolas()
        {
            return (Szemely)MemberwiseClone();
        }

        public override string ToString()
        {
            return "Vezetéknév: " + vezeteknev + " Keresztnév: " + keresztnev + " Születési idő: " + szuletesIdeje + " Fizetés: " + HaviFizetes.Fizetes + " Magasság: " + magassag + " Házas: " + hazas;
        }

        public string Vezeteknev
        {
            set { vezeteknev = value; }
        }

        public DateTime SzuletesIdeje
        {
            get { return szuletesIdeje; }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matek;

namespace Szemely_osztaly
{
    public enum Alkatok {Sovány,Normál,Túlsúlyos}
    class SzemelyTestTomegIndex:ITestTomegIndex
    {
        private string keresztnev;
        private DateTime szuletesIdeje;
        private long fizetes;
        private double magassag;
        private bool hazas;
        private int testtomeg;

        public SzemelyTestTomegIndex(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas, int testtomeg)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
            this.testtomeg = testtomeg;
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
        
        public double TTISzamol(double x)
        {
            return Math.Round(x / (magassag * magassag), 2);
        }

        /*public double TestTomegIndex()
        {
            return Math.Round(testtomeg / (magassag * magassag),2);
        }*/

        public Enum Alkat(double x)
        {
            if (TTISzamol(x) > 25)
            {
                return Alkatok.Túlsúlyos;
            }
            else
            {
                if (TTISzamol(x) < 18.5)
                {
                    return Alkatok.Sovány;
                }
                else
                {
                    return Alkatok.Normál;
                }
            }
        }
        
        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Tömeg: " + testtomeg + " Magasság: " + Magassag + " TTI: " + TTISzamol((double)testtomeg) + " Alkat: " + Alkat((double)testtomeg);
        }
    }
}

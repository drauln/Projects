using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class SzemelyTestTomegIndex
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
        
        public double TestTomegIndex()
        {
            return Math.Round(testtomeg / (magassag * magassag),2);
        }

        public string Alkat()
        {
            if (TestTomegIndex()>25)
            {
                return "Túlsúlyos.";
            }
            else
            {
                if (TestTomegIndex()<18.5)
                {
                    return "Sovány.";
                }
                else
                {
                    return "Normál.";
                }
            }
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Tömeg: " + testtomeg + " Magasság: " + Magassag  + " TTI: " + TestTomegIndex() + " Alkat: " + Alkat();
        }
    }
}

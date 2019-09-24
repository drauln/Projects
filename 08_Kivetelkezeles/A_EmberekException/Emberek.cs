using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using Szulo_osztaly;

namespace Emberek_osztaly
{
    class Emberek
    {
        private Szemely[] szemelyek;

        public Emberek(int maxSzemelySzam)
        {
            szemelyek = new Szemely[maxSzemelySzam];
        }
        
        public void Feltolt(int index, Szemely szemely)
        {
            try
            {
                szemelyek[index] = szemely;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
        }

        public int TombMaxMeret()
        {
            int nemUresTomb = 0;
            try
            {
                for (int i = 0; i < szemelyek.Length; i++)
                {
                    if (szemelyek[i] != null)
                    {
                        nemUresTomb++;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            return nemUresTomb;
        }

        public Szemely IndexedikElem(int index)
        {
            return szemelyek[index];
        }

        public int NemNullElem()
        {
            int nemNull = 0;
            try
            {
                for (int i = 0; i < szemelyek.Length; i++)
                {
                    if (szemelyek[i] != null)
                    {
                        nemNull++;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            return nemNull;
        }

        public double AtlagMagassag()
        {
            double atlagMagassag = 0;
            try
            {
                for (int i = 0; i < TombMaxMeret(); i++)
                {
                    atlagMagassag += szemelyek[i].Magassag;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            return atlagMagassag/TombMaxMeret();
        }

        public int SzulokSzama()
        {
            System.Type szuloTipus = typeof(Szulo);
            int szulokSzama=0;
            try
            {
                for (int i = 0; i < TombMaxMeret(); i++)
                {
                    System.Type szemelyekTipus = szemelyek[i].GetType();

                    if (szemelyekTipus == szuloTipus)
                    {
                        szulokSzama++;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            
            return szulokSzama;
        }

        public override string ToString()
        {
            return szemelyek.ToString();
        }
    }
}
/*
 * Készítsen egy Emberek osztályt, amely Szemelyeket képes tárolni!
Legyen egy Szemely tömb adattagja,
- legyen egy konstruktora, amely paraméterben megkapja a Szemelyek max. számát és ilyen mérettel hozza létre a tömböt,
- legyen egy metódusa, amely paraméterben megkap egy index-et és egy Szemely-t és a tömb indexedik  elemének értékül adja a kapott Szemely referenciáját,
- legyen metódusa, amely visszaadja a tömb méretét, azaz a Személyek max számát,
- legyen metódusa, amely paraméterként egy indexet kap és visszaadja a tömb indexedik elemét,
- legyen metódusa, amely visszaadja, hogy hány darab nem null értékű tömbelem van,
- legyen metódusa, amely visszaadja a Szemelyek átlagos magasságát,
- legyen metódusa, amely visszadja a Szülő típusú Szemelyek számát!
*/
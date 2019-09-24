using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matek;
using Szemely_osztaly;

namespace Testsuly_tablazat
{
    class Futtathato
    {
        static void TTIFuggvenyTablazat(ITestTomegIndex obj, int min, int max)
        {
            for (double i = min; i < max; i += 0.5)
            {
                if (obj.TTISzamol(i) > 25)
                {
                    Console.WriteLine("TTI: " + obj.TTISzamol(i) + " | Alkat: " + Alkatok.Túlsúlyos);
                }
                else
                {
                    if (obj.TTISzamol(i) < 18.5)
                    {
                        Console.WriteLine("TTI: " + obj.TTISzamol(i) + " | Alkat: " + Alkatok.Sovány);
                    }
                    else
                    {
                        Console.WriteLine("TTI: " + obj.TTISzamol(i) + " | Alkat: " + Alkatok.Normál);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string vezeteknev;
            string keresztnev;
            int ev;
            int honap;
            int nap;
            long fizetes;
            double magassag;
            bool hazas;
            int testtomeg;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            double min = 1.5;
            double max = 2.2;

            SzemelyTestTomegIndex[] ember = new SzemelyTestTomegIndex[5];

            for (int i = 0; i < 5; i++)
            {
                vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                ev = rnd.Next(1940, 2011);

                honap = rnd.Next(1, 13);

                nap = rnd.Next(1, 28);
                DateTime szuletesIdeje = new DateTime(ev, honap, nap);

                fizetes = rnd.Next(60001, 200001);

                magassag = Math.Round(rnd.NextDouble() * (max - min) + min, 1); //Kerekítés 1 tizedesjegyre

                if (rnd.Next(0, 1) == 0)
                {
                    hazas = false;
                }
                else
                {
                    hazas = true;
                }

                testtomeg = rnd.Next(50, 111);

                ember[i] = new SzemelyTestTomegIndex(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas, testtomeg);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }


            int minTomeg = rnd.Next(40, 61);
            int maxTomeg = rnd.Next(80, 121);
            TTIFuggvenyTablazat(ember[4], minTomeg, maxTomeg);

            Console.ReadLine();
        }
    }
}
/*Készítsen egy Futtathato nevű futtatható osztályt, amelyben hozzon létre egy osztályszintű metódust,
 * amely paraméterként megkap egy ITestTomegIndex-t és kiírja a kapott TTI függvénytáblázatát min és max közötti tömeggel 0,5 lépéssel (min, max a 2. és 3. paraméter)!
A Main-ben hozzon létre 5 SzemelyTestTomegIndex példányt véletlenszerú adatokkal és tárolja egy tömbbe! Majd írja ki az összes személy TTI képletét, 
majd írassa ki az előző metódus segítségével az utolsó személy függvénytáblázatát véletlen min. és max. értékekkel!
*/
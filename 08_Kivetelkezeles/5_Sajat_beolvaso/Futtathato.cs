using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Sajat_egesz_beolvaso
{
    class Futtathato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg, hogy hány Személy adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());
            string vezeteknev;
            string keresztnev;
            int ev;
            int honap;
            int nap;
            bool hazas;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            
            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                ev = rnd.Next(1940, 2011);

                honap = rnd.Next(1, 13);

                nap = rnd.Next(1, 28);
                DateTime szuletesIdeje = new DateTime(ev, honap, nap);

                if (rnd.Next(0, 2) == 0)
                {
                    hazas = false;
                }
                else
                {
                    hazas = true;
                }
                Console.WriteLine("Adjon meg egy Fizetést és Magasságot(méterben).");
                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, Convert.ToInt64(kiveteles.SajatEgeszBeolvas.EgeszBeolvas(Console.ReadLine())), kiveteles.SajatValosBeolvas.ValosBeolvas(Console.ReadLine()), hazas); //Fizetés long (Int64), EGeszBeolvas int (Int32)
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }
            
            Console.ReadKey();
        }
    }
}

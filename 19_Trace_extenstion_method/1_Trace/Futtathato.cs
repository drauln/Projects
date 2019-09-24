using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Szemely_osztaly;

namespace Trace_Futtathato
{
    class Futtathato
    {
        static TraceSwitch kapcsolo = new TraceSwitch("Trace Kapcsoló","Trace leíró");
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg, hogy hány Személy adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());
            string vezeteknev;
            string keresztnev;
            int ev;
            int honap;
            int nap;
            long fizetes;
            double magassag;
            bool hazas;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            double min = 1.5;
            double max = 2.2;
            
            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
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

                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            int veletlenszam = rnd.Next(0, 5);

            Console.WriteLine("Random: " + veletlenszam);

            if (veletlenszam == 0) kapcsolo.Level = TraceLevel.Off;
            if (veletlenszam == 1) kapcsolo.Level = TraceLevel.Error;
            if (veletlenszam == 2) kapcsolo.Level = TraceLevel.Warning;
            if (veletlenszam == 3) kapcsolo.Level = TraceLevel.Info;
            if (veletlenszam == 4) kapcsolo.Level = TraceLevel.Verbose;


            if (kapcsolo.Level==TraceLevel.Off)
            {
                Console.WriteLine(ember[0].Kiir0());
            }

            if (kapcsolo.Level == TraceLevel.Error)
            {
                Console.WriteLine(ember[0].Kiir1());
            }

            if (kapcsolo.Level == TraceLevel.Warning)
            {
                Console.WriteLine(ember[0].Kiir2());
            }

            if (kapcsolo.Level == TraceLevel.Info)
            {
                Console.WriteLine(ember[0].Kiir3());
            }

            if (kapcsolo.Level == TraceLevel.Verbose)
            {
                Console.WriteLine(ember[0].Kiir4());
            }

            Console.ReadKey();
        }
    }
}

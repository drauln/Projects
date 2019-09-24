using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace B_Lancolt_lista
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

            Console.WriteLine();


            // LancoltLista használata
            LinkedList<Szemely> lancoltLista = new LinkedList<Szemely>();

            lancoltLista.AddFirst(ember[0]);
            
            
            for (int i = 2; i < (elemszam-2); i++)
            {
                lancoltLista.AddLast(ember[i]);
            }

            lancoltLista.AddLast(ember[9]);
            lancoltLista.AddAfter(lancoltLista.Find(ember[0]), ember[8]);   //utolsó előtti embert tesszük a lista második helyére
            lancoltLista.AddBefore(lancoltLista.Find(ember[9]), ember[1]);  //második embert tesszük a lista utolsó előtti helyére
            
            Console.WriteLine("Láncolt lista kiíratás");
            foreach (object elem in lancoltLista)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}

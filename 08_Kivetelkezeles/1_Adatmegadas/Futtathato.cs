using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace kiveteles
{
    class Futtathato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg, hogy hány Személy adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());
            string vezeteknev="";
            string keresztnev="";
            int ev=0;
            int honap=0;
            int nap=0;
            long fizetes=0;
            double magassag=0;
            bool hazas=false;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            bool ujra = false;

            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Vezetéknevét.");
                        vezeteknev = Console.ReadLine();
                        if (vezeteknev.Length < 3)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rövid Vezetéknév.");
                        ujra = true;
                    }
                } while (ujra);


                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Keresztnevét.");
                        keresztnev = Console.ReadLine();
                        if (keresztnev.Length < 3)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rövid Keresztnév.");
                        ujra = true;
                    }
                } while (ujra);
                
                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Születési Évét.");
                        ev = int.Parse(Console.ReadLine());
                        if (ev>2012||ev<1917)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valótlan év.");
                        ujra = true;
                    }
                } while (ujra);

                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Születési Hónapot.");
                        honap = int.Parse(Console.ReadLine());
                        if (honap > 12 || honap < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rossz hónap.");
                        ujra = true;
                    }
                } while (ujra);

                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Születési Napot.");
                        nap = int.Parse(Console.ReadLine());
                        if (DateTime.DaysInMonth(ev,honap) < nap || 1 > nap)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rossz nap.");
                        ujra = true;
                    }
                } while (ujra);
                DateTime szuletesIdeje = new DateTime(ev, honap, nap);

                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Fizetését.");
                        fizetes = long.Parse(Console.ReadLine());
                        if (fizetes < 47000 || fizetes > 200000)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hibás fizetés.");
                        ujra = true;
                    }
                } while (ujra);

                do
                {
                    ujra = false;
                    try
                    {
                        Console.WriteLine("Adja meg a Magasságát méterben.");
                        magassag = double.Parse(Console.ReadLine());
                        if (magassag < 1.2 || magassag > 2.2)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valótlan magasság.");
                        ujra = true;
                    }
                } while (ujra);
                
                do
                {
                    ujra = false;
                    hazas = false;
                    try
                    {
                        
                        Console.WriteLine("Adja meg, hogy Házas-e írja be 'igen' vagy 'nem'.");
                        string beolvas = Console.ReadLine();
                        if (beolvas.Equals("igen")||beolvas.Equals("nem"))
                        {
                            switch (beolvas)
                            {
                                case "igen": { hazas = true; break; }
                                case "nem": { hazas = false; break; }
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rossz válasz.");
                        ujra = true;
                    }
                } while (ujra);
                
                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine();

            for (int i = 0; i < elemszam; i++)
            {
                ember[i].Novel(15000);
                Console.WriteLine(ember[i].ToString());
            }

            ember[0].Vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];
            Console.WriteLine(ember[0].ToString());

            for (int i = 0; i < elemszam; i++)
            {
                if (ember[i].FizetesIntervalluma(80000, 150000))
                {
                    Console.WriteLine(ember[i].Vezeteknev + " fizetése az intervallumba esik.");
                }
                
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString() + " Adó: " + ember[i].Ado(16));
            }

            for (int i = 0; i < elemszam-1; i++)
            {
                if (Szemely.NagyobbE(ember[i].Fizetes,ember[i+1].Fizetes))
                {
                    Console.WriteLine(i + ". ember fizetése nagyobb mint " + (i+1) + ". emberé.");
                }
                else
                {
                    Console.WriteLine(i + ". ember fizetése NEM nagyobb mint " + (i + 1) + ". emberé.");
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiveteles
{
    class SajatEgeszBeolvas
    {
        public static int EgeszBeolvas(string szoveg)
        {
            int egesz=0;
            bool ujra = false;
            do
            {
                ujra = false;
                try
                {
                    egesz = Convert.ToInt32(szoveg);
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("InvalidCastException.");
                    Console.WriteLine("Adjon meg egy számot");
                    szoveg = Console.ReadLine();
                    ujra = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException.");
                    Console.WriteLine("Adjon meg egy számot");
                    szoveg = Console.ReadLine();
                    ujra = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("OverflowException.");
                    Console.WriteLine("Adjon meg egy számot");
                    szoveg = Console.ReadLine();
                    ujra = true;
                }

            } while (ujra);
            return egesz;
        }

    }
}
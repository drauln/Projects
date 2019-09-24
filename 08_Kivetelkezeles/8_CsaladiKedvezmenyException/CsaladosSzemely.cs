using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Csalados_szemely
{
    class CsaladosSzemely:Szemely
    {
        private int gyerekekSzama;
        private int minimumGyerekek;
        private bool kellEHazassag;

        public CsaladosSzemely(string vezeteknev,string keresztnev,DateTime szuletesIdeje,long fizetes,double magassag,bool hazas,int gyerekekSzama, int minimumGyerekek, bool kellEHazassag) : base(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas)
        {
            this.gyerekekSzama = gyerekekSzama;
            this.minimumGyerekek = minimumGyerekek;
            this.kellEHazassag = kellEHazassag;
        }

        private double egyForeJutoJovedelem;

        public double EgyForeJutoJovedelem
        {            
            get
            {
                int x = 1;
                if (Hazas)
                {
                    x = 2;
                }
                egyForeJutoJovedelem = (Fizetes / (gyerekekSzama + x));
                return egyForeJutoJovedelem;
            }
            set { egyForeJutoJovedelem = value; }
        }

        public bool SzuksegesHazasssag
        {
            get { return kellEHazassag; }
        }

        public void CsaladiKedvezmeny()
        {
            try
            {
                if (gyerekekSzama>=minimumGyerekek)
                {
                    if (kellEHazassag==true && Hazas==false)
                    {
                        int szuksegesGyerkekSzama = 0;
                        throw new CsaladiKedvezmenyException.CsaladiKedvezmenyException("Nem jár kedvezmény, mert házasnak kellene lennie.", SzuksegesHazasssag, szuksegesGyerkekSzama);
                    }
                    else
                    {
                        Console.WriteLine("Jár a családi kedvezmény.");
                    }
                }
                else
                {
                    throw new CsaladiKedvezmenyException.CsaladiKedvezmenyException("Nem jár kedvezmény, nincs elég gyerek.", kellEHazassag, (minimumGyerekek - gyerekekSzama));
                }
            }
            catch (CsaladiKedvezmenyException.CsaladiKedvezmenyException cske)
            {
                Console.WriteLine(cske.ToString());
            }
        }

        public override string ToString()
        {
            return base.ToString()+" Gyerekek száma: " + gyerekekSzama +" Házas: "+ Hazas;
        }

        public int GyerekekSzama()
        {
            return gyerekekSzama;
        }

        public static bool NagyobbEgyForeJutoJovedelem(CsaladosSzemely egyik,CsaladosSzemely masik)
        {
            if (egyik.egyForeJutoJovedelem>masik.egyForeJutoJovedelem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
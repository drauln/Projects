using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idos
{
    class Hatarido:feladat.INovelheto,IComparable
    {
        public DateTime hatarIdo;

        public Hatarido(int ev,int honap, int nap, int ora, int perc)
        {
            bool feltetel = true;
            if (ev<2017)
            {
                feltetel = false;
            }
            if (honap<1||honap>12)
            {
                feltetel = false;
            }
            if (nap<DateTime.DaysInMonth(ev,honap)||nap<1)
            {
                feltetel = false;
            }
            if (ora>23||ora<0)
            {
                feltetel = false;
            }
            if (perc<0||perc>59)
            {
                feltetel = false;
            }
            if (feltetel==false)
            {
                throw new ErvenytelenIdoException();
            }
            else
            {
                hatarIdo = new DateTime(ev, honap, nap, ora, perc, 0);//0 a másodperc, mert csak perc pontossággal kell dolgoznunk.
            }
        }

        public Hatarido(string datum)
        {
            DateTime hatarIdoProba = Convert.ToDateTime(datum);
            int ev = hatarIdoProba.Year;
            int honap = hatarIdoProba.Month;
            int nap = hatarIdoProba.Day;
            int ora = hatarIdoProba.Hour;
            int perc = hatarIdoProba.Minute;

            bool feltetel = true;
            if (ev < 2017)
            {
                feltetel = false;
            }
            if (honap < 1 || honap > 12)
            {
                feltetel = false;
            }
            if (nap < DateTime.DaysInMonth(ev, honap) || nap < 1)
            {
                feltetel = false;
            }
            if (ora > 23 || ora < 0)
            {
                feltetel = false;
            }
            if (perc < 0 || perc > 59)
            {
                feltetel = false;
            }
            if (feltetel == false)
            {
                throw new ErvenytelenIdoException();
            }
            else
            {
                hatarIdo = new DateTime(ev, honap, nap, ora, perc, 0);//0 a másodperc, mert csak perc pontossággal kell dolgoznunk.
            }
        }

        public void Novel(int percekSzama)
        {
            int ev = hatarIdo.Year;
            int honap = hatarIdo.Month;
            int nap = hatarIdo.Day;
            int ora = hatarIdo.Hour;
            int perc = hatarIdo.Minute+percekSzama;
            
            if (perc>59)
            {
                perc -= 59;
                ora++;
            }
            if (ora>23)
            {
                ora -= 23;
                nap++;
            }
            if (nap>DateTime.DaysInMonth(ev,honap))
            {
                honap++;
                nap -= DateTime.DaysInMonth(ev, honap);
            }
            if (honap>12)
            {
                ev++;
                honap -= 12;
            }
        }

        public void Novel(string percekSzama)
        {
            DateTime szovegesDatum = Convert.ToDateTime(percekSzama);
            int ev = hatarIdo.Year;
            int honap = hatarIdo.Month;
            int nap = hatarIdo.Day;
            int ora = hatarIdo.Hour + szovegesDatum.Hour;
            int perc = hatarIdo.Minute + szovegesDatum.Minute;
            
            if (perc > 59)
            {
                perc -= 59;
                ora++;
            }
            if (ora > 23)   //Ha 23:59 volt + határidő is 23:59 akkor szükséges egy plusz if()
            {
                ora -= 23;
                nap++;
                if (ora>23)
                {
                    ora -= 23;
                    nap++;
                }
            }
            if (nap > DateTime.DaysInMonth(ev, honap))
            {
                honap++;
                nap -= DateTime.DaysInMonth(ev, honap);
            }
            if (honap > 12)
            {
                ev++;
                honap -= 12;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Hatarido masikHatarIdo = obj as Hatarido;
            if (masikHatarIdo != null)
            {
                return hatarIdo.CompareTo(masikHatarIdo.hatarIdo);
            }
            else
            {
                throw new ArgumentException("Hiba történt, nem megfelelő a határidő.");
            }
        }

        public int PercKulonbseg(DateTime egyik, DateTime masik)
        {
            if (egyik.CompareTo(masik) == 1)
            {
                return egyik.Minute - masik.Minute;
            }
            if (egyik.CompareTo(masik) == -1)
            {
                return masik.Minute - egyik.Minute;
            }
            if (egyik.CompareTo(masik) == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return "Határidő: " + hatarIdo.Year + "." + hatarIdo.Month + "." + hatarIdo.Day + ". " + hatarIdo.Hour + ":" + hatarIdo.Minute;
        }
    }
}
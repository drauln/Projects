using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus_tomb_osztaly
{
    class GenerikusTomb<T>
    {
        private T[] tomb;

        public GenerikusTomb(int elemszam)
        {
            if (elemszam<1)
            {
                Console.WriteLine("Nem megfelelő az elemszám.");
            }
            else
            {
                tomb = new T[elemszam];
            }
        }

        public T Get(int index)
        {
            if (IndexEllenorzes(index))
            {
                return tomb[index];
            }
            else
            {
                return default(T);
            }
        }

        public void Set(int index,T ertek)
        {
            if (IndexEllenorzes(index))
            {
                tomb[index] = ertek;
            }
        }

        public T this[int index]
        {
            get
            {
                if (IndexEllenorzes(index))
                {
                    return tomb[index];
                }
                else
                {
                    //ref.típus esetén null, érték típus esetén 0 értéket ad vissza
                    return default(T);
                }
            }
            set
            {
                if (IndexEllenorzes(index))
                {
                    tomb[index] = value;
                }
            }
        }

        public bool IndexEllenorzes(int index)
        {
            if (index < 0 || index > tomb.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
/*Hozzon létre egy GenerikusTomb osztályt, legyen egy generikus tomb adattagja, getter, setter metódusa, indexere!
A futtatható osztályban hozzon létre egy személyeket tartalazó GeerikusTombot!
Töltse fel 10 generált személlyel és írassa ki az adataikat!
*/
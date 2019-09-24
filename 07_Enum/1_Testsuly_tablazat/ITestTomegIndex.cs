using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matek
{
    interface ITestTomegIndex
    {
        double TTISzamol(double x);

        Enum Alkat(double x);
    }
}
/*a. Definiáljon egy matek.ITestTomegIndex nevű interfészt!
b. Deklaráljon benne egy „TTISzamol” nevű metódust, amely egy egész számot kap és egy valós számot ad vissza!
Szerepe, egy megadott x tömeg értékre visszaadni a kiszámolt test tömeg indexet.
c. Legyen benne metódus, amely visszaad egy alkatot jellemző enum értéket!
*/
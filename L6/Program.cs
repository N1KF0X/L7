using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lada lada = new Lada(21, 34, 55, "Лада");
            Boing boing = new Boing(43, 64, 66, "Боинг");
            Titanik titanik = new Titanik(65, 81, 11, "Титаник");

            lada.Info();
            boing.Info();
            titanik.Info();
        }
    }
}

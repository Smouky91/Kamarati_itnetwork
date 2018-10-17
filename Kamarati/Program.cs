using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamarati
{
    class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek1 = new Clovek();
            clovek1.meno = "Karel Novák";
            clovek1.vek = 33;
            Clovek clovek2 = new Clovek();
            clovek2.meno = "Josef Nový";
            clovek2.vek = 27;

            clovek1.kamarat = clovek2;
            clovek2.kamarat = clovek1;

            clovek1.Predstavenie();
            clovek2.Predstavenie();
            Console.ReadKey();
        }
    }
}

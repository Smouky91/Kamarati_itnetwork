using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamarati
{
    class Clovek
    {
        public string meno;
        public int vek;
        public Clovek kamarat;

        public void Predstavenie()
        {
            Console.WriteLine("Ahoj, volam sa {0}, mam {1} rokov a moj kamarat je {2}.", meno, vek, kamarat.meno);
        }
    }
}

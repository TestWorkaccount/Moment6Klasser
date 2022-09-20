using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    class Bil
    {
        public string Märke { get; set; }
        public string Modell { get; set; }

        public Bil() //default konstruktor //har inga element och skapas alltid om det inte finns någon konstruktor
        {

        }

        public Bil(string märke, string modell) //konstruktor som tar 2 argument
        {
            Märke = märke;
            Modell = modell;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    class Person
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Fullnamn { get { return Förnamn + " " + Efternamn; } }

        //public double BMI { get { return vikten / (längden * längden); } }

        public bool Myndig { get { return KollaMyndigÅlder(); } }

        private bool KollaMyndigÅlder()
        {
            DateTime födelseÅr = new DateTime(2005, 5, 16);
            DateTime nutid = DateTime.Now;
            TimeSpan tidSomHarGått = nutid - födelseÅr;
            double ålder = tidSomHarGått.Days / 365.2425;
            if (ålder >= 18)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new Bil();
            bil.Märke = "Mercedes";
            bil.Modell = "Benz C63";

            Bil bil2 = new Bil("Volvo", "V40");


            Person person = new Person();
            //person.Födelsedatum = new DateTime(1987, 5, 16);

            Console.WriteLine("Är personen myndig: " + person.Myndig);
        }


    }
}

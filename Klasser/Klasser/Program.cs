using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            InkomstInfo[] inkomster = new InkomstInfo[3];
            for(int i = 0; i < inkomster.Length; i++)
            {
                InkomstInfo info = InkomstInfo.SkapaInkomstInfoMedReadLine();
                inkomster[i] = info;
            }

            for(int i = 0; i < inkomster.Length; i++)
            {
                InkomstInfo nuvarande = inkomster[i];
                Console.WriteLine(nuvarande.Namn + " timlön blev: " + nuvarande.Timlön + " kr/h");
            }

            

            


            //InkomstInfo info = new InkomstInfo();

            //Console.Write("Ange ditt namn: ");
            //info.Namn = Console.ReadLine();
            //Console.Write("Ange din inkomst: ");
            //info.Inkomst = int.Parse(Console.ReadLine());
            //Console.Write("Ange antal timmar: ");
            //info.Timmar = int.Parse(Console.ReadLine());

            //Console.WriteLine("Din timlön blev: " + info.Timlön + " kr/h");

            Console.ReadKey();
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class InkomstInfo //Klassnamn //börja med stor bokstav och nya ord ska också ha stor bokstav
    {
        public string Namn { get; set; } //Egenskap Property
        public int Inkomst { get; set; } //Egenskap Property
        public int Timmar { get; set; } //Egenskap Property
        
        public int Timlön { get { return Inkomst / Timmar; } } //Beräknad Egenskap Property 

        private int pengarIMadrassen; //variabel/field //bara den egna klassen tjäner till pengarna i madrassen
        protected int arveGods; //variabel/field //bara mina arvingar och barn känner till mitt arvegods. 

        int enProtectedVariabel; //variabel/field //den är protected om man in defineriar åtkomstmodifierare/acces modifier

        public static InkomstInfo SkapaInkomstInfoMedReadLine()
        {
            InkomstInfo info = new InkomstInfo();

            Console.Write("Ange ditt namn: ");
            info.Namn = Console.ReadLine();
            Console.Write("Ange din inkomst: ");
            info.Inkomst = int.Parse(Console.ReadLine());
            Console.Write("Ange antal timmar: ");
            info.Timmar = int.Parse(Console.ReadLine());
            
            return info;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi_12._01._24
{
    internal class opiskelija : Henkilö
    {
        public string opiskelijaID;
        public string tutkinto;
        public int vuosikurssi;

        public static int Opiskelijoa = 0;
        public opiskelija(string nimi, int ikä, string kotikaupunki, string hetu,
            string opiskelijaID, string tutkinto, int vuosikurssi) : base(nimi, ikä, kotikaupunki, hetu)
        {
            this.opiskelijaID = opiskelijaID;
            this.tutkinto = tutkinto;
            this.vuosikurssi = vuosikurssi;
        }

        public override void TulostaTiedot()
        {
            base.TulostaTiedot();
            Console.WriteLine("OpiskelijaID: " + opiskelijaID);
            Console.WriteLine("Tutkinto: " + tutkinto);
            Console.WriteLine("Kurssi Vuosi:" + vuosikurssi);

            Opiskelijoa++;
        }
    }
}

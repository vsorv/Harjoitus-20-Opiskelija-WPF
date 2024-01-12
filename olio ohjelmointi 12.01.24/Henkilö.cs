using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi_12._01._24
{
    internal class Henkilö
    {
        public string nimi;
        public int ika;
        public string kotikaupunki;
        public string hoba;

        public static int Henkiloja = 0;

        public Henkilö(string nimi, int ika, string kotikaupunki, string hoba)
        {
            this.nimi = nimi;
            this.ika = ika;
            this.kotikaupunki = kotikaupunki;
            this.hoba = hoba;
        }
        public virtual void TulostaTiedot() 
        {
            Console.WriteLine("Tiedot");
            Console.WriteLine("nimi: " + nimi);
            Console.WriteLine("ika: " + ika);
            Console.WriteLine("kotikaupunki: " + kotikaupunki);
            Console.WriteLine("Henkilo tunnus: " + hoba);

            Henkiloja++;
        }
    }
}

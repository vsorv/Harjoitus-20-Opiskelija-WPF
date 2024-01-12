using olio_ohjelmointi_12._01._24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Henkilö henkilö = new Henkilö("Matti", 30, "Loviisa", "146294-253C");
            opiskelija opiskelija = new opiskelija("Pekka", 18, "Porvoo", "121005-285f", "L2921", "Ohjelmistokehittäjä", 3);
            henkilö.TulostaTiedot();

            Console.WriteLine("");
            Console.WriteLine("");

            opiskelija.TulostaTiedot();

            Console.WriteLine("");
            Console.WriteLine("Henkilöiden määrä = " + Henkilö.Henkiloja);
            Console.WriteLine("Opiskelijoiden määrä = " + opiskelija.Opiskelijoa);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule v = new Vehicule();
            Vehicule v1 = new Auto();
            // Auto a = new Vehicule(); // pas possible
            Auto c3 = new Auto();
            Console.WriteLine(c3 is Vehicule);
            Console.WriteLine(c3 is Auto);
            Console.WriteLine(v is Vehicule);
            Console.WriteLine(v is Auto);
            Console.WriteLine(v1 is Auto);

            c3.Klaxonner();
            ((Auto)v1).Klaxonner();
            // ((Auto)v).Klaxonner(); // pas possible

            // Auto v3 = (Auto)v; ça plante ! voir écriture as
            if (v is Auto)
            {
                Auto v3 = (Auto)v;
            }

            Auto v2 = v as Auto;
            if (v2 == null)
                Console.WriteLine("Conversion impossible !");

            Auto v5 = v1 as Auto;
            if (v5 != null)
                Console.WriteLine("Conversion effectuée !");

            Vehicule v4 = c3 as Vehicule;
            if (v4 != null)
                Console.WriteLine("Conversion effectuée !");

            Console.Read();
        }
    }
    class Vehicule { }
    class Auto : Vehicule
    {
        public void Klaxonner() { }
    }
}

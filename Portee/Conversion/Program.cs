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
            Vehicule v = new Vehicule();            //  v est un Vehicule qui se comporte comme un vehicule   
            Vehicule v1 = new Auto();               // v1 est un Vehicule qui se comporte comme une auto
            // Auto a = new Vehicule(); // Pas possible
            Auto c3 = new Auto();
            Console.WriteLine(c3 is Auto);
            Console.WriteLine(c3 is Vehicule);
            Console.WriteLine(v is Vehicule);
            Console.WriteLine(v is Auto);
            Console.WriteLine(v1 is Auto);
            

                                                               // On peut convertir s'il existe une relation d'héritage entre deux objets (?)

            ((Auto)v1).Klaxonner();                            // Permet de convertir v1 en auto
            // ((Auto)v).Klaxonner();                          // n'est pas possible
            // Auto v3 = (Auto)v;                                 // Ca plante
            // var v2 = v1 as Auto;                               // On récupère, dans v2, la conversion de v1 en Auto
            var v2 = v as Auto;                             // Ca ne fonctionne pas, mais ca ne plante pas. v2 ici récupèrera une valeur null 
            if (v2 == null)
                Console.WriteLine("Conversion impossible");

            Auto v5 = v1 as Auto;
            if (v5 != null)
                Console.WriteLine("Conversion effectuée");
            
            Vehicule v4 = c3 as Vehicule;
            if (v4 != null)
                Console.WriteLine("Conversion effectuée");

            Console.Read();

        }
    }

    class Vehicule { }                                      // Un auto est un véhicule, un véhicule n'est pas forcément une auto
    
    class Auto : Vehicule
    {
        public void Klaxonner()
        {

        }
    }

}

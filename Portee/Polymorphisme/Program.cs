using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicule v = new Vehicule();
            // v.Rouler();
            // Vehicule a = new Auto();            // on peut dire que a est un véhicule, qui se comporte comme une auto
            // a.Rouler();
            // Vehicule m = new Moto();            // de la même manière, on peut dire que m est un véhicule, qui se comporte comme une moto
            // m.Rouler();

            IVehicule v;
            Console.WriteLine("tapez auto ou moto");
            var s = Console.ReadLine();
            if (s == "auto")
                v = new Auto();
            else
                v = new Moto();
            v.Rouler();

            Console.Read();
        }
    }
    abstract class Vehicule                         // N'est pas instanciable directement. On ne pourra donc pas écrire Vehicule v = new Vehicule
    {
        public virtual void Rouler()                                        //virtual et override vont de paires
        {
            Console.WriteLine("Le véhicule roule !");
        }
    }

    interface IVehicule
    {
        void Rouler();
    }

    interface IHabitation {

        void SeChauffer();
    }

    class Auto : IVehicule, IHabitation             // On dit que Auto implémente IVehicule et IHabitation
    {
     public void Rouler()
        {
            Console.WriteLine("L'auto roule !");
        }
        
      public void SeChauffer()
        {

        }     
    }                              

    class Moto : IVehicule
    {
        public void Rouler()
        {
            Console.WriteLine("La moto roule !");
        }

    }

}

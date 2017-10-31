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
            //Vehicule v = new Vehicule();
            //v.Rouler();
            //Vehicule a = new Auto();
            //a.Rouler();
            //Vehicule m = new Moto();
            //m.Rouler();

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
    abstract class Vehicule
    {
        public virtual void Rouler()
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
    class Auto : IVehicule, IHabitation
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

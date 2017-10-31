using System;
using System.Collections;
using System.Collections.Generic;

namespace CentraleNucleaire
{
    class CentraleEventArgs : EventArgs
    {
        public int Temperature;
        public int Pression;
    }
    delegate void RefroidirDelegate(CentraleEventArgs args);
    class Program
    {
        static void Main(string[] args)
        {
            Centrale bugey = new Centrale();
            bugey.Refroidir();

            Console.Read();
        }
    }
    class Centrale
    {
        //private ArrayList ListePompe = null;
        //private List<RefroidirDelegate> ListeDelegue;
        private event RefroidirDelegate Alerte;

        public Centrale()
        {
            //ListePompe = new ArrayList();
            //ListeDelegue = new List<RefroidirDelegate>();

            PompeHydraulique p1 = new PompeHydraulique();
            PompeHydraulique p2 = new PompeHydraulique();
            PompeElectrique p3 = new PompeElectrique();
            PompeManuelle p4 = new PompeManuelle();

            //ListePompe.Add(p1);
            //ListePompe.Add(p2);
            //ListePompe.Add(p3);
            //ListePompe.Add(p4);

            //ListeDelegue.Add(new RefroidirDelegate(p1.Refroidir));
            //ListeDelegue.Add(new RefroidirDelegate(p2.Refroidir));
            //ListeDelegue.Add(new RefroidirDelegate(p3.Refroidir));
            //ListeDelegue.Add(new RefroidirDelegate(p4.Refroidir));
            //ListeDelegue.Add(new RefroidirDelegate(p4.Evacuer));

            Alerte += new RefroidirDelegate(p1.Refroidir);
            Alerte += new RefroidirDelegate(p2.Refroidir);
            Alerte += new RefroidirDelegate(p3.Refroidir);
            Alerte += new RefroidirDelegate(p4.Refroidir);
            Alerte += new RefroidirDelegate(p4.Evacuer);
        }


        public void Refroidir()
        {
            //foreach(var pompe in ListePompe)
            //{
            //    if (pompe is PompeHydraulique)
            //        ((PompeHydraulique)pompe).Refroidir();
            //    if (pompe is PompeElectrique)
            //        ((PompeElectrique)pompe).Refroidir();
            //}
            var args = new CentraleEventArgs { Temperature = 3000, Pression = 50 };

            //foreach (var delegue in ListeDelegue)
            //{
            //    delegue.Invoke(args);
            //}
            Alerte(args);
        }
    }
    class PompeHydraulique
    {
        public void Refroidir(CentraleEventArgs args)
        {
            Console.WriteLine("Lancement de la pompe hydraulique : Temperature={0}, Pression={1}",
                args.Temperature, args.Pression);
        }
    }
    class PompeElectrique
    {
        public void Refroidir(CentraleEventArgs args)
        {
            Console.WriteLine("Lancement de la pompe électrique");
        }
    }
    class PompeManuelle
    {
        public void Refroidir(CentraleEventArgs args)
        {
            Console.WriteLine("Lancement de la pompe manuelle");
        }
        public void Evacuer(CentraleEventArgs args)
        {
            Console.WriteLine("Evacuation");
        }
    }
}

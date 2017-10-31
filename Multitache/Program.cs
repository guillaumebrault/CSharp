using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitache
{
    class Program
    {
        static void Main(string[] args)
        {
            Compteur c1 = new Compteur("C1");
            //c1.Go(1, 20, 1, ConsoleColor.Yellow);
            var d1 = new CompteurDelegate(c1.Go);
            Compteur c2 = new Compteur("C2");
            var d2 = new CompteurDelegate(c2.Go);
            Compteur c3 = new Compteur("C3");
            var d3 = new CompteurDelegate(c3.Go);

            d1.BeginInvoke(1, 10, 1, ConsoleColor.Yellow, null, null);
            d2.BeginInvoke(1, 5, 1, ConsoleColor.Red, null, null);
            d2.BeginInvoke(1, 20, 1, ConsoleColor.Cyan, null, null);
            Console.WriteLine("Fini");
            Console.Read();
        }
    }
    delegate void CompteurDelegate(int min, int max, int pause, ConsoleColor couleur);
    class Compteur
    {
        public string Nom;
        public Compteur(string n)
        {
            this.Nom = n;
        }

        public void Go(int min, int max, int pause, ConsoleColor couleur)
        {
            for (int i = min; i <= max; i++)
            {
                Console.ForegroundColor = couleur;
                Console.WriteLine("{0}:{1}", Nom, i);
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(pause * 1000);
            }
        }
    }
}

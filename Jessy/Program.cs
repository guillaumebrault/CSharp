using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jessy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructeur
            Paradis eden = new Paradis();
            Paradis bali = new Paradis("Michel");

            // Garbage collector (Jessy) : libération mémoire
            Machine m = new Machine();
            var t = m.go();
            var q = m.go2();

            m.go3();
        }
    }
    class Paradis : Ciel, IDisposable
    {
        public string Ange = string.Empty;
        public string Couleur;
        public Paradis()
        {
            // Ciel(); // pas possible voir base.
            Couleur = "Blanc";
        }
        public Paradis(string a) : this()
        {
            // Paradis(); // pas possible voir this.
            Ange = a;

        }
        public Paradis(int a)
        {

        }

        public void Dispose()
        {

        }
    }
    class Ciel
    {
        public Ciel()
        {

        }
        public Ciel(string nom)
        {

        }
    }
    class Machine
    {
        public string go()
        {
            string s = "machine androïd de 3e génération";
            return s;
        }
        public Paradis go2()
        {
            Paradis p = new Paradis();
            return p;
        }
        public void go3()
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                //var p = new Paradis();
                // GC.Collect(); // Trop long

                using (var p = new Paradis())
                {

                }
            }
        }
    }
}

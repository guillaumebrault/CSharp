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
            Paradis eden = new Paradis();                           // Paradis() est une méthode qui s'appelle Paradis, qui ne prend aucun paramètre. 
            Paradis jardin = new Paradis("Michel");                 // Si on ne définit pas de constructeur, le constructeur choisi est le constructeur par défaut. Si on définit un constructeur autre que le constructeur par défaut, sans que le constructeur par défaut soit explicite, c'est le constructeur défini qui est choisi

            // Garbage Collector (Jessy)                            // Jessy ne se charge que la mémoire (qui est une ressource. Elle ne s'occupe pas des autres ressources). C'est un service windows (tourne en boucle quand processeur dispo). 
            Machine m = new Machine();                              // Jessy fait appel à la méthode finalize(méthode à écrire, qui permet de libérer les autres ressources que l'objet a pris. C'est à nous de le définir) que l'objet possède forcément. Elle vide la mémoire
            var t = m.go();
            var q = m.go2();
        }
    }

    class Paradis : Ciel, IDisposable
    {
        public string Ange = string.Empty;
        // public Paradis()                                          // Paradis est un constructeur. Il est ici explicite. Permet d'instancier des objets. Le constructeur qui ne prend aucun parametre est un constructeur par défaut
        // {
        //     Ange = "Gabriel";
        // }

        public string Couleur;
        public Paradis() : base("x")                                   // cherche un constructeur qui est juste au-dessus qui prend un string comme paramètre. 
        {
            // Ciel(); pas possible, voir base
            Couleur = "Blanc";
        }

        public Paradis(string a ) : this()                          // Ecrire le : this() signifie que l'on fait appelle à // Paradis(); . Cherche dans la classe où l'on est
        {
            // Paradis();       // Pas possible, voir this juste au-dessus.
            Ange = a;
        }

        public Paradis(int a)
        {

        }

        public void Dispose()                                       // Dire ce que l'on veut libérer comme ressource
        {
            throw new NotImplementedException();
        }
    }

    class Ciel
    {
        public Ciel()
        {

        }

        public Ciel(string s)
        {

        }

    }

    class Machine
    {
        public string go()
        {
            string s = "machine androïd de 3e generation";
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
            //     var p = new Paradis();
            //     GC.Collect(); // Trop long, car fait le ménage partout.
            // 
             using (var p = new Paradis())              // using fait appel à finalize
                {

                }
            }
        }
    }
}

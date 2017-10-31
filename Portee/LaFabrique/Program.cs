using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFabrique
{
    class Program
    {
        static void Main(string[] args)
        {
            var personnes = new Personnes();

            
            
                personnes.Add(new Personne {Nom="Alain",Ville="Paris"}),
                personnes.Add(new Personne { Nom="Guillaume", Ville="Budapest" }),
                personnes.Add(new Personne { Nom="Rémy", Ville="Strasbourg" }),
                personnes.Add(new Personne { Nom="Qing", Ville="Berlin" }),
                personnes.Add(new Personne { Nom="Célia", Ville="Marseille" }),
                personnes.Add(new Personne { Nom="Nadia", Ville="Casablanca" }),
                personnes.Add(new Personne { Nom="João", Ville="Lisbonne" }),
                personnes.Add(new Personne { Nom = "Ali", Ville = "Lyon" });   

            //Personne p1 = personnes[0];
            foreach (var p in personnes)
            {
                Console.WriteLine(p);
            }

            Console.Read();
        
        }

    }
    
    class Personne
    {
        public string Nom;
        public string Ville;
        public override string ToString()
        {
            return Nom + " de la ville de " + Ville;
        }
    }

    class Personnes : IEnumerable<Personne>
    {
        private List<Personne> listeInterne = new List<Personne>();

        internal void Add(Personne p)
        {
            if ((p.Nom != "Ali" || p.Ville != "Lyon"))
                listeInterne.Add(p);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnes personnes = new Personnes();

            personnes.Add(new Personne { Nom = "Alain", Ville = "Paris" });
            personnes.Add(new Personne { Nom = "Guillaume", Ville = "Budapest" });
            personnes.Add(new Personne { Nom = "Rémy", Ville = "Strasbourg" });
            personnes.Add(new Personne { Nom = "Qing", Ville = "Berlin" });
            personnes.Add(new Personne { Nom = "Célia", Ville = "Marseille" });
            personnes.Add(new Personne { Nom = "Nadia", Ville = "Casablanca" });
            personnes.Add(new Personne { Nom = "João", Ville = "Lisbonne" });
            personnes.Add(new Personne { Nom = "Ali", Ville = "Lyon" });

            Personne p1 = personnes[0];

            Console.WriteLine(p1);
            Console.ReadLine();

            foreach(var p in personnes)
            {
                Console.WriteLine(p);
            }

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
        private List<Personne> listeinterne = new List<Personne>();
        public Personne this [int index]
        {
            get { return listeinterne[index]; }
           
        }

        internal void Add(Personne p)
        {
            if (p.Nom != "Ali" || p.Ville != "Lyon")
                listeinterne.Add(p);
        }
        public IEnumerator<Personne> GetEnumerator()
        {
            return new PersonneEnumerator(listeinterne);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonneEnumerator(listeinterne);
        }

        internal void Remove (Personne p)
        {
            if (p.Nom != "Alain")
                listeinterne.Remove(p);
        }
    }

    class PersonneEnumerator : IEnumerator<Personne>
    {
        private List<Personne> Liste = new List<Personne>();
        private int Index = -1;

        public PersonneEnumerator (List<Personne> liste)
        {
            Liste = liste;
        }

        public Personne Current
        {
            get
            {
                return Liste[Index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Liste[Index];
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Index++;
            return Index < Liste.Count;
        }

        public void Reset()
        {
            Index = -1;
        }
    }
}

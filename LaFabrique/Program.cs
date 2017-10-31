using System;
using System.Collections;
using System.Collections.Generic;


namespace LaFabrique
{
    class Program
    {
        static void Main(string[] args)
        {
            var personnes = new Personnes();

            personnes.Add(new Personne { Nom = "Alain", Ville = "Paris" });
            personnes.Add(new Personne { Nom = "Guillaume", Ville = "Budapest" });
            personnes.Add(new Personne { Nom = "Remy", Ville = "Strasbourg" });
            personnes.Add(new Personne { Nom = "Qing", Ville = "Berlin" });
            personnes.Add(new Personne { Nom = "Célia", Ville = "Marseille" });
            personnes.Add(new Personne { Nom = "Nadia", Ville = "Casablanca" });
            personnes.Add(new Personne { Nom = "João", Ville = "Lisboa" });
            personnes.Add(new Personne { Nom = "Ali", Ville = "Lyon" });

            Personne p1 = personnes[0];
            Console.WriteLine(p1);
            Console.WriteLine();

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

        public Personne this[int index]
        {
            get { return listeInterne[index]; }
        }

        internal void Add(Personne p)
        {
            if (p.Nom != "Ali" || p.Ville != "Lyon")
                listeInterne.Add(p);
        }

        public IEnumerator<Personne> GetEnumerator()
        {
            return new PersonneEnumerator(listeInterne);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonneEnumerator(listeInterne);
        }

        internal void Remove(Personne p)
        {
            if (p.Nom != "Alain") listeInterne.Remove(p);
        }
    }
    class PersonneEnumerator : IEnumerator<Personne>
    {
        private List<Personne> Liste;
        private int Index = -1;
        public PersonneEnumerator(List<Personne> liste)
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

        public void Dispose() { }

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

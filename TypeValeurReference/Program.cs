using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeValeurReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne { Nom="Einstein", Prenom="Albert" };
            Personne p2;
            p2 = p1;
            p2.Prenom = "Roger";
            p2.Feminin = false;
            p2.Dexterite = DexteriteEnum.Gaucher;
            int i = 17;
            int j = 0;
            j = i;
            j++;

            // Créer ses propres classes de type valeur
            // Cas 1 : enum

            // Cas 2 : struct
        }
    }
    [Flags]
    enum DexteriteEnum { Droitier=1, Gaucher=2, Ambidextre=3 }
    struct Personne
    {
        public string Nom;
        public string Prenom;
        public bool Feminin;
        public DexteriteEnum Dexterite;
    }
}

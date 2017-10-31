using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Pas de i à ce niveau


namespace Portee
{
    // Pas de i à ce niveau
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne { Nom = "Macron", Prenom = "Hollande", Age = 39 };
            Personne p2 = new Personne { Nom = "Hollande", Prenom = "Francois", Age = 60 };
            Personne p3 = new Personne { Nom = "Morin", Prenom = "Francois", Age = 60 };



          
            #region if
                if (p1.Age > 18)
            {
                p1.ClassAge = p1.ClassAge = ClassAgeEnum.Adulte;
                if (p1.Age > 50)

                {
                    p1.ClassAge = ClassAgeEnum.Vieux;
                }
            }
            else if (p1.Age<3)
            {
                p1.ClassAge = ClassAgeEnum.Bebe;
            }

            #endregion

            #region switch

            switch (p1.ClassAge)                // Le switch se comporte comme un "if", il faut bien retenir la syntaxe
            {
                case ClassAgeEnum.Adolescent:
                    Console.WriteLine("ca va bien !");
                    break;
                case ClassAgeEnum.Adulte:       // Pour faire un "ou", il faut écrire les deux case (les rassembler) à la suite. Ne pas mettre de virgule.
                    Console.WriteLine("Bonjour");
                    break;
                case ClassAgeEnum.Bebe:
                    Console.WriteLine("Areu !");
                    break;
                default:
                    Console.WriteLine("Hi !");
                    break;


            }
            #endregion


            #region while et for

            int i = 1;
            while (i <= p1.Age)

            {
                Console.WriteLine(i);
                i++;
            }                                   // Un break permet de sortir d'une boucle (à utiliser avec parcimonie)

            for (int j=1; j<=p1.Age; j++)    // initialisation puis condition, on vérifie la condition, on execute, puis on fait la 3e partie, puis on vérifie la condition, puis on fait la 3e partie, etc.)
            {
                Console.WriteLine(j);            // Il est correct d'écrire for (int i=1, m=2; condition sur i, condition sur m; incrémentation sur i, incrémentation sur m) 
            }
            #endregion


            #region do while

            int k = 1;
            do
            {
                Console.WriteLine(k);
                k++;
            }

            while (k <= p1.Age);


            #endregion

        }


    }
























    class Personne
    {
        public string Nom;
        public string Prenom;
        public int Age;
        public ClassAgeEnum ClassAge = ClassAgeEnum.Indefini;
    }

    [Flags] // Cet attribut permet de faire un masque binaire.
    enum ClassAgeEnum { Bebe, Enfant, Adolescent, Adulte, Vieux, Indefini }
}


    /* class Program2
    // 
    // {
    //     int i;       // Ici, le i est une "propriété"
    //     
    //     {
    //         int i;  // Ici, le i est une "variable"
    //     }
    // 
    //     static void methode2(int i)             // Ici, le i est un "paramètre"
    //     {
    // 
    //     }
    // 
    }

    
}
*/
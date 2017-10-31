using System;

namespace Portee
{

    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne { Nom = "Macron", Prenom = "Emmanuel", Age = 39 };
            Personne p2 = new Personne { Nom = "Hollande", Prenom = "François", Age = 60 };
            Personne p3 = new Personne { Nom = "Morin", Prenom = "François", Age = 3 };

            #region If
            if (p1.Age > 18)
            {
                p1.ClassAge = ClassAgeEnum.Adulte;
                if (p1.Age > 50)
                {
                    p1.ClassAge = ClassAgeEnum.Vieux;
                }
            }
            else if (p1.Age < 3)
            {
                p1.ClassAge = ClassAgeEnum.Bebe;
            }
            #endregion

            #region Switch
            switch (p1.ClassAge)
            {
                case ClassAgeEnum.Adolescent:
                    Console.WriteLine("ca va bien !");
                    break;
                case ClassAgeEnum.Adulte:
                case ClassAgeEnum.Vieux:
                    Console.WriteLine("Bonjour !");
                    break;
                case ClassAgeEnum.Bebe:
                    Console.WriteLine("Areu !");
                    break;
                default:
                    Console.WriteLine("Hi !");
                    break;
            }
            #endregion

            #region While
            int i = 1;
            while (i <= p1.Age)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int j = 1, m = 2; j <= p1.Age; j++, m += 5)
            {
                Console.WriteLine(j);
            }
            #endregion

            #region do While
            int k = 1;
            do
            {
                Console.WriteLine(i);
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
    enum ClassAgeEnum { Bebe, Enfant, Adolescent, Adulte, Vieux, Indefini }
}

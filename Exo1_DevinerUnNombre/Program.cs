using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1_DevinerUnNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Partie p = new Partie();
            p.Init();
            p.Jouer();
            Console.Read();
        }
    }
    class Joueur 
    {
        public int NEssai = 0;
        public int Proposition = 0;
        public bool DonnerPropo()
        {
            while (true)
            {
                string s = Console.ReadLine();
                int propo = 0;
                if (int.TryParse(s, out propo))
                {
                    Proposition = propo;
                    return true;
                }
                return false;
            }
        }
    }
    class Partie
    {
        public int MaxEssai = 7;
        public int BonneReponse = 0;
        public Joueur Utilisateur;
        private Random Alea = new Random();
        public void Init()
        {
            BonneReponse = Alea.Next(1, 99);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(BonneReponse);
            Console.ForegroundColor = ConsoleColor.Gray;
            Utilisateur = new Joueur();
        }
        public ResultatEnum Comparaison()
        {
            if (Utilisateur.DonnerPropo())
            {
                if (Utilisateur.NEssai >= MaxEssai)
                    return ResultatEnum.Perdu;
                Utilisateur.NEssai++;
                if (Utilisateur.Proposition < BonneReponse)
                    return ResultatEnum.TropPetit;
                if (Utilisateur.Proposition > BonneReponse)
                    return ResultatEnum.TropGrand;
                return ResultatEnum.Gagne;
            }
            else
            {
                Utilisateur.NEssai++;
                return ResultatEnum.MauvaisePropo;
            }
        }
        public void Jouer()
        {
            ResultatEnum r = ResultatEnum.Init;
            while (!(r == ResultatEnum.Gagne || r == ResultatEnum.Perdu))
            {
                r = Comparaison();
                switch (r)
                {
                    case ResultatEnum.Perdu:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Perdu");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.Gagne:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gagné !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.TropPetit:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Trop petit ! ({0})",
                            this.MaxEssai - Utilisateur.NEssai + 1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.TropGrand:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Trop grand ! ({0})",
                            this.MaxEssai - Utilisateur.NEssai + 1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.MauvaisePropo:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Proposition incorrecte ! ({0})",
                            this.MaxEssai - Utilisateur.NEssai + 1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
        }
    }
    enum ResultatEnum { TropGrand, TropPetit, Gagne, Perdu, Init, MauvaisePropo }
}

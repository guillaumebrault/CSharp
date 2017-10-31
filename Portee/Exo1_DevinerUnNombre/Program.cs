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
        public int NEssais = 0;
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
        public int MaxEssai = 7;                                // On initialise et déclare la variable MaxEssai, en la fixant à 7
        public int BonneReponse = 0;                            // On initialise et déclare la variable BonneReponse
        public Joueur Utilisateur;
        private Random Alea = new Random();


        public void Init()                                      // Methode qui permet de lancer la partie : 
        {
            BonneReponse = Alea.Next(1, 99);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(BonneReponse);
            Console.ForegroundColor = ConsoleColor.Gray;
            Utilisateur = new Joueur();
        }

        public ResultatEnum Comparaison()                       // Methode qui permet de comparer la réponse de l'utilisateur et celle du nombre aléatoire générer par la machine
        {
           if (Utilisateur.DonnerPropo())
            {
                if (Utilisateur.NEssais >= MaxEssai)
                    return ResultatEnum.Perdu;
                Utilisateur.NEssais++;
                if (Utilisateur.Proposition < BonneReponse)
                    return ResultatEnum.TropPetit;
                if (Utilisateur.Proposition > BonneReponse)
                    return ResultatEnum.TropGrand;
                return ResultatEnum.Gagner;
            }
            else
            {
                Utilisateur.NEssais++;
                return ResultatEnum.MauvaisePropo;

            }
        }
        
        
        
        
        

        public void Jouer()
        {
            ResultatEnum r = ResultatEnum.Init;
            while (!(r ==ResultatEnum.Gagner || r==ResultatEnum.Perdu))
            {
                r = Comparaison();  
                switch (r)
                {
                    case ResultatEnum.Perdu:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Perdu");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.Gagner:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gagné !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.TropGrand:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("C'est trop grand ({0})", MaxEssai - Utilisateur.NEssais+1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.TropPetit:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("C'est trop petit({0})", MaxEssai - Utilisateur.NEssais + 1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ResultatEnum.MauvaisePropo:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Proposition Incorrecte ! ({0})", MaxEssai - Utilisateur.NEssais + 1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    
                                                   
                }
            }
        }  
    }

    enum ResultatEnum { TropGrand, TropPetit, Gagner, Perdu, Init, MauvaisePropo }

}

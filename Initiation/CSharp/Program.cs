using System;

namespace CSharp
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour tout le monde");
            Console.WriteLine("Construction des maisons");

            Console.WriteLine("Maison 1 :");
            Maison maison1 = new Maison();
            maison1.Peindre("Rouge");

            Console.WriteLine("Maison 2 :");                                    // Ici, le 2e "Maison" est une méthode
            Maison maison2;
            maison2 = new Maison();                                             // Les 2 maisons, maison1 et maison2 ont les mêmes propriétés/méthodes/événements (?) que celle de la classe Maison. Le 1er "Maison" est une classe/type, maison1 et maison2 sont des objets de la classe Maison.On peut dire que maison1 est une instance (objet et instance sont des synonymes)            
            maison2.Peindre("jaune");     
                                           
            Console.Read();                     
        }
    }
    public class Voiture
    {
        string Volant; // 
        string Carrosserie;
        string Roues;

        void Arreter()
        {

        }
        void Demarrer()
        {

        }
        void PasserUneVitesse()
        {

        }

        event EventHandler FeuRouge;
    }
    public class MultiPrise
    {
        string Connecteur="Connecteur789";
        int Tension = 220;

        void OnOFF()
        {
      
        }

        event EventHandler Foudre;

    }
    public class Maison
    {
        public string Couleur = "Bleu";
        public int Superficie = 0;
        public string Mur="";
        public string Portes;
        public string Fenetres;      

        public void CalculerSuperficie()
        {
        }
        public void Habiter()
        {
        }
        public void Peindre(string nouvelleCouleur)
        {
            Couleur = nouvelleCouleur;
        }
    }
}

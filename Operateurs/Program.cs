using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b1 = new Boite { Longueur = 2, Largeur = 3, Hauteur = 4 };
            Boite b2 = new Boite { Longueur = 1, Largeur = 2, Hauteur = 3 }; ;
            Boite b = b1 + b2;
            Boite b3 = 3 * b1;
            Boite b4 = b1 * 3;

            Carton c = (Carton) b4;
        }
    }
    class Boite
    {
        public int Longueur;
        public int Largeur;
        public int Hauteur;
        public static Boite operator +(Boite a, Boite b)
        {
            Boite newBoite = new Boite();
            newBoite.Longueur = a.Longueur + b.Longueur;
            newBoite.Largeur = a.Largeur + b.Largeur;
            newBoite.Hauteur = a.Hauteur + b.Hauteur;
            return newBoite;
        }
        public static Boite operator *(int a, Boite b)
        {
            Boite newBoite = new Boite();
            newBoite.Longueur = a * b.Longueur;
            newBoite.Largeur = a * b.Largeur;
            newBoite.Hauteur = a * b.Hauteur;
            return newBoite;
        }
        public static Boite operator *(Boite b, int a)
        {
            return a * b;
        }
        public static explicit operator Carton (Boite b)
        {
            return null;
        }
    }
    class Carton
    {
        public int Longueur;
        public int Largeur;
        public int Hauteur;
    }
}

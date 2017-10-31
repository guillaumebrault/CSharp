using System;
using espace2;

namespace CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bonjour tout le monde");
            Console.WriteLine("Construction des maisons");

            Console.WriteLine("Maison 1 :");
            Maison maison1 = new Maison();
            maison1.Peindre("Rouge");

            Console.WriteLine("Maison 2 :");
            Maison maison2;
            maison2 = new Maison();
            maison2.Peindre("Jaune");

            Console.Read();
        }
    }
}
namespace espace3
{
    class class31 { }
}
namespace espace2
{
    public partial class Maison
    {
        public void Peindre(string nouvelleCouleur)
        {
            Couleur = nouvelleCouleur;
        }
    }

}

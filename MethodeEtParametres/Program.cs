using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeEtParametres
{
    class Program
    {
        static void Main(string[] args)
        {
            Bd Lagaffe = new Bd
            {
                Auteur = "Franquin",
                Editeur = "Dupuy",
                NombrePage = 50,
                Prix=20.5M
            };
            string phrase = Lagaffe.Description();
            AuteurEditeur a = Lagaffe.Infos();

            Lagaffe.Augmentation(10, 3);

            string auteur, editeur; int n;
            Lagaffe.Get(out auteur, out editeur, out n);

            Lagaffe.AddPlanches("planche1", "planche2");

            Console.WriteLine(phrase);

            // Méthode récursive
           
            int i = Math.Factoriel(7);


            Console.Read();
        }
    }
    class Bd
    {
        public void AddPlanches(params string[] tableau)
        {
            for(int index=0; index < tableau.Length; index++)
            {
                Planches.Add(tableau[index]);
            }
        }
        public void Augmentation(int valeur, int marge=0)
        {
            Prix *= 1 + valeur / 100 + marge;
        }

        public string Auteur;
        public string Editeur;
        public int NombrePage;
        public decimal Prix;
        public List<string> Planches = new List<string>();

        //public void Description()
        //{
        //    Console.WriteLine(
        //        "bande dessinée écrite par " +
        //        Auteur +
        //        " aux éditions Dupuy. " +
        //        NombrePage +
        //        " pages."
        //        );
        //}
        public string Description()
        {
            return
                "bande dessinée écrite par " +
                Auteur +
                " aux éditions Dupuy. " +
                NombrePage +
                " pages.";
        }
        public AuteurEditeur Infos()
        {
            AuteurEditeur ae = new AuteurEditeur();
            ae.Auteur = Auteur;
            ae.Editeur = this.Editeur;
            return ae;
        }

        public void Get(out string a, out string e, out int n)
        {
            a = Auteur; e = Editeur; n = NombrePage;
        }

    }
    class AuteurEditeur
    {
        public string Auteur;
        public string Editeur;
    }
    class Math
    {
        public static int Factoriel(int n)
        {
            if (n == 1) return 1;
            return n * Factoriel(n - 1);
        }
    }
}

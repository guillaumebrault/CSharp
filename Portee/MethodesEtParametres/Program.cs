using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//D'après OC, nous pouvons comparer des classes à des types et les objets à des variables


namespace MethodesEtParametres
{
    class Program
    {
        static void Main(string[] args)
        {
            Bd Lagaffe = new Bd { Auteur = "Franquin", Editeur = "Dupuy", NombrePage=50, Prix=20.5M };   // Lagaffe est une variable de la classe Bd, dont la classe a été créée en dessous. Cette variable va donc recevoir tous les paramètres de la classe bd
            string phrase = Lagaffe.Description();
            AuteurEditeur a = Lagaffe.Infos();
            Lagaffe.Augmentation(10, 3);
            

            string auteur, editeur; int n;
            Lagaffe.Get(out auteur, out editeur, out n);              // out permet de dire au paramètre de retourner qqchose

            Lagaffe.AddPlanches("planche1", "planche2");
                   
            Console.WriteLine(phrase);

            // Méthode récursive
            Math m = new Math();
            int i = m.Factoriel(7);

            Console.Read();
        }
    }
    class Bd
    {
        public void AddPlanches(params string[] tableau)                // params permet de tran
        {
            for (int index=0; index < tableau.Length; index++)              // tableau.Length est la longueur du tableau. T
            {
                Planches.Add(tableau[index]);
            }
        }
        public string Auteur;
        public string Editeur;
        public int NombrePage;
        public decimal Prix;
        public List<string> Planches = new List<string>();

       // public void Description()
       // {
       //     Console.WriteLine("Bande dessinée écrite par" + Auteur + "aux éditions Dupuy." + NombrePage + "pages.");
       // 
       // }

        public string Description()
        {
            return
                "Bande dessinée écrite par " + Auteur + " aux éditions Dupuy." + NombrePage + " pages.";

        }

        public AuteurEditeur Infos()
        {
            AuteurEditeur ae = new AuteurEditeur();
            ae.Auteur = Auteur;                        // this permet de donner l'objet dans la classe où l'on se situe
            ae.Editeur = this.Editeur;
            return ae;
        }

        public void Augmentation(int valeur, int marge=0)                   // Mettre en dernier les paramètres avec des valeurs par défaut.
        {
            Prix = Prix * (1 + (valeur / 100) + marge);     // Simlaire à Prix*=1 + valeur / 100 + marge
        }

        public void Get( out string a, out string e, out int n)
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
        public int Factoriel(int n)
        {
            if (n==1)
            {
                return 1;
            }
            return n * Factoriel(n - 1);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surcharge
{
    class Program
    {
        static void Main(string[] args)
        {
            Championnat Ligue1 = new Championnat();
            Ligue1.Equipes.Add("PSG");              // Add vient de la liste créée en-dessous, car elle fait partie du framework list
            Ligue1.Equipes.Add("OL");
            Ligue1.Equipes.Add("OM");
            Ligue1.Equipes.Add("Nice");

            var resultat = Ligue1.Match(false, "PSG", "OL");   // Dire var, ca dit au compilateur qu'il connait le type de retour du résultat (ici, resultat est de type ResultatMatch car c'est dit dans : public ResultatMatch Match(string locaux, string visiteurs).
            Console.WriteLine(resultat);                
        }
    }

    enum ResultatMatch { Locaux, Visiteurs, MatchNul }
    class Championnat
    {
        public Random Alea = new Random();
        public List<string> Equipes = new List<string>();
        public ResultatMatch Match(string locaux, string visiteurs)
        {
            int r = Alea.Next(1, 3);
            switch(r)                                           // "switch selon la valeur de r"
            {
                case 1: return ResultatMatch.Locaux;
                case 2: return ResultatMatch.Visiteurs;
                default : return ResultatMatch.MatchNul;
            }

        }

        public ResultatMatch Match(string locaux, string visiteurs, bool forfaitVisiteurs)                          // On ne peut pas avoir 2 méthodes qui ont la même signature (c.a.d, le nom de la méthode, le nb de paramètres, le type de chacun des paramètres. Le type de retour ne fait pas partie de la signature, tout comme le nom des paramètres. Il est bon d'en utiliser beaucoup
        {
            if (forfaitVisiteurs)
                return ResultatMatch.Locaux;
            else
                return Match(locaux, visiteurs);
        }

        public ResultatMatch Match(bool forfaitLocaux, string locaux, string visiteurs)
        {
            if (forfaitLocaux)
                return ResultatMatch.Visiteurs;
            else
                return Match(locaux, visiteurs);
        }
    }
                                                                                                                // On dit que la méthode Match est surchargée (overload), car il en existe plusieurs, mais avec des signatures différentes.

}

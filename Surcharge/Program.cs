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
            Ligue1.Equipes.Add("PSG");
            Ligue1.Equipes.Add("OL");
            Ligue1.Equipes.Add("OM");
            Ligue1.Equipes.Add("Nice");

            var resultat = Ligue1.Match(false, "PSG", "OL");

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
            switch (r)
            {
                case 1: return ResultatMatch.Locaux; 
                case 2: return ResultatMatch.Visiteurs; 
                default: return ResultatMatch.MatchNul; 
            }
        }
        public ResultatMatch Match(string locaux, string visiteurs, bool forfaitVisiteurs)
        {
            if (forfaitVisiteurs)
                return ResultatMatch.Locaux;
            else
                return this.Match(locaux, visiteurs);
        }
        public ResultatMatch Match(bool forfaitLocaux, string locaux, string visiteurs)
        {
            if (forfaitLocaux)
                return ResultatMatch.Visiteurs;
            else
                return this.Match(locaux, visiteurs);
        }
    }
}

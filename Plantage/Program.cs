using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Donnez le premier opérande : ");
            string operande1Str = Console.ReadLine();
            Console.Write("Donnez le second opérande : ");
            string operande2Str = Console.ReadLine();

            decimal op1 = 0, op2 = 0;
            if (decimal.TryParse(operande1Str.Replace(".", ","), out op1) &&
                decimal.TryParse(operande2Str.Replace(".", ","), out op2))
            {
                if (op2 == 0)
                {
                    Console.Write("Je ne divise pas par zéro ! ");
                }
                else
                {
                    decimal resultat = op1 / op2;
                    Console.WriteLine(resultat);
                }
            }
            else
                Console.Write("Opérande(s) erroné(s) ! ");

            // Exception
            try
            {
                decimal k = 1 / op2;
                Imprimer(op2);
                Console.WriteLine("Impression effectuée.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erreur : divison par zéro");
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("Erreur bizarre");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Fin impression.");
            }
            Console.Read();
        }
        static void Imprimer(decimal i)
        {
            if (i == 13)
                throw new FormatException("L'imprimante est hors d'usage !");
        }
    }
}

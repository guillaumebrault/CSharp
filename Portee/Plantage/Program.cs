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
            Console.Write("Donner le premier opérande : ");             //WriteLine écrit et passe à la ligne. Write écrit sur la même ligne
            string operande1Str = Console.ReadLine();
            Console.Write("Donner le deuxieme opérande : ");
            string operande2Str = Console.ReadLine();

            decimal op1=0, op2=0;                         //int.Parse permet de convertir la variable dans Parse, en un entier. TryParse permet, contrairement au Parse, de ne pas faire planter le programme. TryParse retourne un booléen
            if (decimal.TryParse(operande1Str.Replace(".",","), out op1) && decimal.TryParse(operande2Str.Replace(".", ","), out op2))      // La fonction Replace("élément à remplacer","élément qui remplace") permet de remplacer une lettre/chiffre/symbole par un autre.
            {
                
                if (op2 == 0)
                {
                    Console.WriteLine("Je ne divise pas par zero !");
                }

                else
                {
                    decimal resultat = op1 / op2;
                    Console.WriteLine(resultat);
                }

            }
            else
                Console.Write("Opérande(s) erroné(s)!");

            // Exception                                // 2 méthodes pour gérer un plantage : en contournant le plantage (avec le if), ou en prenant en compte le plantage (try-catch)
            try
            {
                decimal k = 12 / op2;                   // try permet de laisser l'exception, puis on récupère la main dans le catch. On aurait pu mettre n'importe quel nombre autre que 12. Autrement dit, dès que le try plante, le catch suivant reprend la main
                Imprimer(op2);
                Console.WriteLine("Impression effectuée !");                // Si la ligne précédente plante, on ne fait l'instruction console.writeline ... Evitez le try si possible, car prend bcp de temps à s'exécuter. A utiliser si trop de if, ou si impossible de faire du if.
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Erreur : division par zéro !");
            }


            catch (Exception e)          // e permet de récupérer l'objet exception
            {                           // Si plusieurs catch, faire du plus spécialisé au plus généralisé. Toujours écrirer le exception généralisé à la fin, car c'est l'exception la plus globale.
                Console.WriteLine(e.Message);
            }
            
            finally                         // Permet d'être executé dans tous les cas, plantage ou pas
            {
                Console.WriteLine("Fin d'impression");
            }

            Console.Read();
        }

        static void Imprimer(decimal i)

        {
            if (i==13)
                throw new Exception("L'imprimante est hors d'usage !");               // Throw permet de planter volontairement. Utile pour se souvenir où on s'est arrêté dans un programme.
        }
    }
}

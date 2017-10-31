using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = 3;
            // int[] tabInt = new int[n];                               // Tableau d'entier, c'est une classe, de type référence.
            // tabInt[0] = 10;
            // tabInt[1] = 20;
            // tabInt[2] = 30;

            int[] tabInt = { 10, 20, 30 };                              // Le tableau comprend qu'il y a 3 éléments

            int[,] matrice = new int[2, 3];                              // Tableau de 6 éléments en 2 dimension
            matrice[0, 0] = 1;
            matrice[0, 1] = 1;
            matrice[0, 2] = 1;
            matrice[1, 0] = 1;
            matrice[1, 1] = 1;
            matrice[2, 0] = 1;

            var i = Array.IndexOf(tabInt, 20);                      //1

            for(int i=0; int<tabInt.Length; i++)
            {
                Console.WriteLine(tabInt[i]);
            }

            foreach(int i in tabInt)
            {
                Console.WriteLine(i);
            }

            Console.Read();

        }
    }
}

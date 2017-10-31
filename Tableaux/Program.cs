using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 3;
            //int[] tabInt = new int[n];
            //tabInt[0] = 10;
            //tabInt[1] = 20;
            //tabInt[2] = 30;

            int[] tabInt = { 10, 20, 30 };

            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 1;
            matrice[0, 1] = 2;
            matrice[0, 2] = 3;
            matrice[1, 0] = 4;
            matrice[1, 1] = 5;
            matrice[1, 2] = 6;

            var index = Array.IndexOf(tabInt, 20); // 1

            for(int i=0; i < tabInt.Length; i++)
            {
                Console.WriteLine(tabInt[i]);
            }

            foreach(var i in tabInt)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}

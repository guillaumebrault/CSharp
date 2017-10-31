using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.P1 = 12;                                                 // J'écris dans p1 (Ecriture - Set)
            //a1.set(12);

            Console.WriteLine(a1.P1);                                   // Je fais une lecture de p1 (Lecture - Get)
            // Console.WriteLine(a1.get());


            B b1 = new B();

}
    }
    #region Encapsulation de propriétés

    // L'encapsulation permet de contrôler.

    class A
    {
        private int p1 = 0;
       // public void set(int value)
       // {
       //     p1 = value;
       // }
       // / public int get()
       // {
       //     return p1;
       // } 

        public int P1
        {
            get { return p1; }
            set { if (value != 8) p1 = value; }                       // get et set sont des méthodes.
        }
        public int P2 { get; set; }                                // Même chose que les lignes de public int p1
        #endregion

        
    }

    class B : A { }
}

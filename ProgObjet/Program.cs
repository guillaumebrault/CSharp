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

            a1.P1 = 8; // Ecriture - set
            //a1.set(12);

            Console.WriteLine(a1.P1); // Lecture - get
            //Console.WriteLine(a1.get());

            B b1 = new B();
            b1.P1 = 5;
        }
    }
    
    #region Encapsulation de propriété
    class A
    {
        //public void set(int value) { p1 = value; } 
        //public int get() { return p1; }

        private int p1 = 0;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public int P2 { get; set; }
        private int P3;
    }
    #endregion
    class B : A
    {

    }
}

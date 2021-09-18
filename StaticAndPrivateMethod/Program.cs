using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPrivateConstructor
{
    class DoSomeMath
    {
        private int x, y;
        private static int a;

        private DoSomeMath(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
       static DoSomeMath()
        {
            if(a < 20)
            {
                a = 15;
            }
            else { a = 50; }
            
        }

        public static void print()
        {
            Console.WriteLine("My int A is now " + a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //DoSomeMath dMath = new DoSomeMath(5, 10); //Private, hence cannot access
            DoSomeMath.print();
            Console.ReadLine();
        }
    }
}

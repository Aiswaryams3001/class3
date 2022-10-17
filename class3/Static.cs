using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Static
    {
        static void Main(string[] args)
        {
            B obj = new B();
            int a = obj.add(5, 6, 7);
            int b = obj.add(10, 20);
            double c = obj.add(2.2, 3.2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        class A
        {
            public int add(int a,int b)
            {
                return a + b;
            }
            public double add(double a,double b)
            {
                return a + b;
            }
        }
        class B:A
        {
            public int add(int a,int b,int c)
            {
                return a+b+c;
            }
        }
    }
}

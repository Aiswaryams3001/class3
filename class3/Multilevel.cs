using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static class3.Program;

namespace class3
{
    internal class Multilevel
    {
        public class A
        {
            public string Name;
            public void GetName()
            {
                Console.WriteLine("Name:{0}", Name);
            }
        }
        public class B:A
        {
            public string Location;
            public void GetLocation()
            {
                Console.WriteLine("Location:{0}", Location);
            }
        }
        public class C:B
        {
            public int Age;
            public void GetAge()
            {
                Console.WriteLine("Age:{0}", Age);
            }
            static void Main(string[] args)
            {
                C c=new C();
                c.Name = "Kat Kristian";
                c.Location = "Mumbai";
                c.Age = 30;
                c.GetName();
                c.GetLocation();
                c.GetAge();
                Console.WriteLine("\npress any key to exit....");
                Console.ReadLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Program
    {
        public class user
        {
            public string Name;
            private string Location;
            public void GetUserInfo(string loc)
            {
                Location = loc;
                Console.WriteLine("Name:{0}",Name);
                Console.WriteLine("Location:{0}", Location);
            }
        }

        public class Details : user
        {
            public int Age;
            public void GetAge()
            {
                Console.WriteLine("Age:{0}", Age);
            }
        }
        static void Main(string[] args)
        {
            Details d=new Details();
            d.Name = "kat kristian";
            d.Age = 30;
            d.GetUserInfo("Mumbai");
            d.GetAge();
            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();

        }
    }
}

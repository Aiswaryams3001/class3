using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static class3.Abstraction;

namespace class3
{
    internal class Encapsulation
    {
        private string location;
        private string name;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        static void Main(string[] args)
        {
            Encapsulation obj = new Encapsulation();
            obj.Name = "Ankita";
            obj.Location = "Kolkata";
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Location);
  
            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();

        }
    }
}

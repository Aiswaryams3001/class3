using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Abstraction
    {
        public class Laptop
        {
            private string brand;
            private string model;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public void LaptopDetails()
            {
                Console.WriteLine("Brand: "+Brand);
                Console.WriteLine("Model: "+Model);
            }
            public void LaptopKeyboard()
            {
                Console.WriteLine("Type using Keyword");
            }
            private void MotherBoardInfo()
            {
                Console.WriteLine("MotherBoard Information");
            }
            private void InternalProcessor()
            {
                Console.WriteLine("Processor Information");
            }
        }
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            l.Brand = "Dell";
            l.Model = "Intel Core i5";
            l.LaptopDetails();
            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();

        }
    }
}

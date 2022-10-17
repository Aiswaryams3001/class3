using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Abstractclass
    {
        static void Main(string[] args)
        {
            Men objmen = new Men();
            objmen.Hair();
            objmen.Legs();
            objmen.Nose();
            Women objwomen = new Women();
            objwomen.Hair();
            Console.ReadKey();
        }
        abstract class Humanbeings
        {
            public void Nose()
            {
                Console.WriteLine("Humanbeings'  Nose() called.");
            }
            public void Legs()
            {
                Console.WriteLine("Humanbeings' Legs() called.");
            }
            public abstract void Hair();

        }
        class Men : Humanbeings
        {
            public override void Hair()
            {
                Console.WriteLine("Men have short hair.");
            }
        }
        class Women :Humanbeings
        {
            public override void Hair()
            {
                Console.WriteLine("Women have short hair.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static class3.Program;

namespace class3
{
    internal class Hierarchial
    {
        static void Main(string[] args)
        {
            Principal g = new Principal();
            g.Monitor();
            Teacher d = new Teacher();
            d.Monitor();
            d.Teach();
            Student s = new Student();
            s.Monitor();
            s.Learn();
            Console.ReadKey();
        }
        class Principal
        {
            public void Monitor()
            {
                Console.WriteLine("Monitor Classes");
            }
        }
        class Teacher:Principal
        {
            public void Teach()
            {
                Console.WriteLine("Teacher Teach");
            }
        }
        class Student:Principal
        {
            public void Learn()
            {
                Console.WriteLine("Student Learn");
            }
        }
    }
}

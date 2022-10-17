using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static class3.Program;

namespace class3
{
    internal class Interface
    {
        interface idetails
        {
            void getdata(string name, double sal);
            void display();
        }
        interface iDesignation
        {
            void getdesig(string designation);
        }
        class employee1 :idetails,iDesignation
        {
            private string ename;
            private double esal;
            private string designation;
            public void getdata(string name,double sal)
            {
                this.ename = name;
                this.esal = sal;    
            }
            public void display()
            {
                Console.WriteLine("Name:" + ename + "\nSalary:" + esal);
            }
            public void getdesig(string designation)
            {
                this.designation = designation;
            }
        }
        static void Main(string[] args)
        {
            employee1 emp = new employee1();
            Console.WriteLine("Enter the Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the Salary:");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Designation:");
            string desig=Console.ReadLine();
            emp.getdata(name,sal);
            emp.getdesig(desig);
            Console.WriteLine("Designation:"+desig);
            Console.ReadKey(); 
            

            Console.ReadLine();
        }
    }
}

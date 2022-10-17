using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Hybrid
    {
        class HeadOffice
        {
            public void HeadOfficeAddress()
            {
                Console.WriteLine("Head Office Address");
            }
        }
        //This part is Hierarcial
        class BranchOffice1:HeadOffice
        {
            public void BranchOfficeAddress()
            {
                Console.WriteLine("Branch Office Address");
            }
        }
        class BranchOffice2 : HeadOffice
        {
            public void BranchOfficeAddress()
            {
                Console.WriteLine("Branch Office Address");
            }
        }
        //This one is Multilevel
        class Employee:BranchOffice2
        {
            public void NameofEmployee()
            {
                Console.WriteLine("Name of the Employee");
            }
            public void Salary()
            {
                Console.WriteLine("Salary of the Employee");
            }
        }
        static void Main(string[] args)
        {
            BranchOffice2 br2=new BranchOffice2();
            br2.HeadOfficeAddress();
            br2.BranchOfficeAddress();
            Employee emp=new Employee();
            emp.NameofEmployee();
            Console.ReadKey();
        }
    }
}

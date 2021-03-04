using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class PartialDemo
    {
        static void Main()
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Keerthana";
            emp.LastName = "Cherukuthota";
            emp.Salary = 999999;
            emp.Gender = "Female";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}

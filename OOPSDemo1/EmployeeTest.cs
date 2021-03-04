using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSDemo1;

namespace OOPSDemo1
{
    class EmployeeTest
    {
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.GetBranchData();
            e1.GetEmployeeData();

            e1.DisplayBranchData();
            e1.DisplayEmployeeData();
            Console.ReadKey();

            int i = 200;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

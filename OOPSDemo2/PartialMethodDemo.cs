using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    public partial class Technician
    {
        partial void setData(); //partial method declaration
    }
    public partial class Technician
    {
        public void setSalary() //testing the partial method
        {
            setData();
        }
        partial void setData() //implement of partial method
        {
            Console.WriteLine("this is partial method");
        }

    }
    class PartialMethodDemo
    {
        static void Main()
        {
            Technician t = new Technician();
            t.setSalary();
            Console.ReadKey();
        }
    }
}

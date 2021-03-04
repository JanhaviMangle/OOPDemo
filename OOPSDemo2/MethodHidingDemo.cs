using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class SuperClass
    {
        public void display()
        {
            Console.WriteLine("Base class display method");
        }
           
    }
    class DerivedClass:SuperClass
    {
        public new void display()
        {
            Console.WriteLine("Derived class display method");
        }
    }
    class MethodHidingDemo
    {
       static void Main()
        {
            DerivedClass d1 = new DerivedClass();
            d1.display();
            Console.ReadKey();
        }
    }
}

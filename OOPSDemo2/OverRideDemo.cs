using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class Developer
    {
        public virtual void getInfo() //virtual methods should be overriden
        {
            Console.WriteLine("I am team leader");
        }
    }
    class CSharpDeveloper:Developer
    {
        public override void getInfo() // method overriden
        {
            Console.WriteLine("I am C# Developer");
        }
    }
    class OverRideDemo
    {
        static void Main()
        {
            CSharpDeveloper c1 = new CSharpDeveloper();
            c1.getInfo();

            Developer d1 = new Developer();
            d1.getInfo();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create a generic method add to perform addition of 2 integers
//float/string in non generic class
namespace CollectionsDemo
{

    class Generics
    {
        public void Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            Console.WriteLine(a + b);
        }
    }
    class NonGenericClass
    {
        static void Main()
        {
            Generics g1 = new Generics();
            g1.Add(10, 20);
            g1.Add(10.2f, 30.3f);
            g1.Add("Hello", "World");



            Console.ReadKey();




        }

    }
}

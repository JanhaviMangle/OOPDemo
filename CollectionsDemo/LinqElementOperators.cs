using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqElementOperators
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.ElementAt(3); //return element at index 3 
            
            Console.WriteLine(MethodSyntax);

            int MethodSyntax1 = numbers.ElementAt(10); //throw exception
            Console.WriteLine(MethodSyntax1);

            int MethodSyntax2 = numbers.ElementAtOrDefault(10); //throw exception
            Console.WriteLine(MethodSyntax2); //will not throw exception, but returns 0

            int MethodSyntax3 = numbers.First(); //fetches first element
            Console.WriteLine(MethodSyntax3);

            int MethodSyntax4 = numbers.FirstOrDefault( num =>num > 50); //fetches first element
            Console.WriteLine(MethodSyntax4);

            int MethodSyntax5 = numbers.Last(); //fetches last element
            Console.WriteLine(MethodSyntax5);

            Console.ReadLine();
        }
    }
}

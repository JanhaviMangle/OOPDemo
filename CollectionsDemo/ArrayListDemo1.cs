using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class ArrayListDemo1
    {
        static void Main()
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList(); list.Add("Manesh");
            list.Add("Akshay");
            list.Add("Vikash");
            list.Add("Anuj");
            list.Add("Dharmesh");
            list.Add("Raman");

            Console.WriteLine("Initial arraylist contents:");
            foreach(string v in list)
            {
                Console.WriteLine(v);
            }
            list.Reverse();
            Console.WriteLine("Arraylist contents after reversing:");
            foreach(string v in list)
            {
                Console.WriteLine(v);
            }
            list.Sort();
            Console.WriteLine( list.BinarySearch("Raman")); //searcher 
            Console.WriteLine("Arraylist contents after sorting:");
            foreach (string v in list)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();

        }
    }
}

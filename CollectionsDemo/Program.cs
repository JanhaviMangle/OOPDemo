using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList a = new System.Collections.ArrayList();
            a.Add("Welcome");
            a.Add(100);
            a.Add(true);
            a.Add(22.2);
            a.Add("Non generic collection");

            Console.WriteLine("ArrayList Count :" + a.Count);
            Console.WriteLine("ArrayList Capacity :" + a.Capacity);

            System.Collections.ArrayList b = new System.Collections.ArrayList();
            a.AddRange(b); // add arraylist b to a // add range will add in th end

            // insert elements into arraylist
            a.Insert(0, "Hello");
            a.Insert(3, 555);

            System.Collections.ArrayList c = new System.Collections.ArrayList();
            a.InsertRange(2, c); // inserting c aaraylist to 2 position in a //insert range will insert in middle



            Console.WriteLine("ArrayList Count :" + a.Count);
            Console.WriteLine("ArrayList Capacity :" + a.Capacity);

            Console.WriteLine("*********ArrayList Elements******");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            string msg = (string)a[0]; //access elements based on index
            float v = (float)a[2];

            Console.WriteLine("Element at 0 is :" + msg);
            Console.WriteLine("Element at 2 is :" + v);

            // Removing an element which is having a value 20.5f

            a.Remove(20.2f);

            // Removing an element at index 0

            a.RemoveAt(0);

            // Removing 2 elements starting from index 3

            a.RemoveRange(3, 2);
            Console.ReadKey();

        }
    }

}



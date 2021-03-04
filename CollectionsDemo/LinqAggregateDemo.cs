using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqAggregateDemo
    {
        static void Main()
        {

            List<int> myIntegerList = new List<int>()
            {
                1,2,3,44,5,33,77,6,9
            };

            int m = myIntegerList.Min();
            int n = myIntegerList.Max();
            double k = myIntegerList.Average();
            int c = myIntegerList.Count();
            int s = myIntegerList.Sum();

            /* Aggregate function is useful to perform the operations on each item of the list.
             * The Aggregate() function will perform the action on the first and second elements
             * and then carry forward the result. */
            double ag = myIntegerList.Aggregate((a, b) => a + b);

            Console.WriteLine("the minimum no. in list is {0}", m);
            Console.WriteLine("the maximum no. in list is {0}", n);
            Console.WriteLine("the average no. in list is {0}", k);
            Console.WriteLine("the total no. in list is {0}", c);
            Console.WriteLine("the multiplication of nos in list is {0}", ag);
            Console.WriteLine("the sum no. in list is {0}", c);

            string[] charlist = { "a", "b", "c", "d" };
            var concat = charlist.Aggregate((a, b) => a + ','+b);
            Console.WriteLine("Concatenated string:{0}", concat);


            Console.ReadKey();


        }
    }
}

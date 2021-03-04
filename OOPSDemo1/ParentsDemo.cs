using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    /* In c#, params keyword is useful to specify a method 
     * parameter that takes a variable number of arguments.
     * The params keyword is useful when we are not sure
     * about the number of arguments to send as a parameter. */

    class ParentsDemo
    {
        static void Main(string[] args)

        {

           // ParamsMethod(1, 2, 3, 4, 5, 6);
            ParamsMethod(1, 2, 30);

        }

        public static void ParamsMethod(params int[] arr)

        {
            int sum=0;
            for (int i = 0; i < arr.Length; i++)

            {
                sum = sum + arr[i];
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));

            }

            Console.WriteLine("the sum of arguments:"+sum);

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }
    }
}

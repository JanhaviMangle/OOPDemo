using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class OutDemo
    {
        static void Main(string[] args)
        {
            int x, y;
            Multiplication(out x, out y);
            Console.WriteLine("x Value: {0}", x);
            Console.WriteLine("y Value: {0}", y);

            Console.ReadKey();
        }

        public static void Multiplication(out int a, out int b)
        {
            a = 10;
            b = 5;

            a *= a;
            b *= b;

        }
    }
}

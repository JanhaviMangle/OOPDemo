using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
   public class SqrtPrecalculated
    {
        public const int MAX_VALUE = 10000;
        private static int[] sqrtValues;
        static SqrtPrecalculated()
        {
            sqrtValues = new int[MAX_VALUE + 1];
            for (int i=0;i<sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }
        public static int GetSqrt(int value)
        {
            return sqrtValues[value];
        }
        static void Main()
        {
            Console.WriteLine(GetSqrt(9));
            Console.ReadKey();
        }
    }
}

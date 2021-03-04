using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
   public static class ExtensionsDemo
    {
        public static bool IsGreaterThan(this int i,int value) //extension method
        {
            return 1 > value;
        }
    }
}

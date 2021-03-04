using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class TestExtensionMethod
    {
        static void Main()
        {
            int i = 10;
            string myWord = "learning c# extension methods is fun:";
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);

            int myWordCount = myWord.GetWordCount();
            Console.WriteLine("String:" + myWord);
            Console.WriteLine("no of words:"+myWordCount);
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class HashTableDemo1
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add(100,"John");
            ht.Add(200, "Raavi");
            ht.Add(300, "Vira");

            //Use DictionaryEntry to display ht contents
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine("Key :{0}-Value :{1}", de.Key, de.Value);
            }
            Console.WriteLine("----------------------------------");

            ICollection key = ht.Keys;

            foreach(var k in key)
            {
                Console.WriteLine(k + " - " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}

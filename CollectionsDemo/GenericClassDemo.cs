using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class DataStore<T> //generic class
    {
        public T Data { get; set; } //generic property

        public DataStore(T val) //generic constructor
        {
            Console.WriteLine(val);
        }
    }
    class GenericClassDemo
    {
        static void Main()
        {
            DataStore<String> store = new DataStore<string>("C# generics");
            store.Data = "Hello world";

            DataStore<int> store1 = new DataStore<int>(500);
            store1.Data = 100;

            Console.WriteLine(store1.Data + " " + store.Data);
            Console.ReadKey();

        }
    }
}

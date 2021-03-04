using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
  public class Animal
    {
        public virtual void eat() { Console.WriteLine("Eating......"); }
        public virtual void run() { Console.WriteLine("Eating......"); }
    }
    public class Dog : Animal
    {
        public override void eat() { Console.WriteLine("Eating bone......"); }
        public sealed override void run() { Console.WriteLine("running fast....."); }
    }

    class BabyDog : Dog
    {
        public override void eat() { Console.WriteLine("Eating biscuits......"); }
        // public override void run()
        //{ Console.WriteLine("running slowly....."); } //through an exception
                                                        //becoz this class is sealed and cannot be overriden

        public void run1() { Console.WriteLine("running slowly....."); }
    }
       
    class SealedMethodDemo
    {
        public static void Main()
        {
            BabyDog d = new BabyDog();
            d.eat();
            d.run();
        }

    }
}

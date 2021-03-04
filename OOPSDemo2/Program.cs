using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    public interface IArea
    {
        void area(double a, double b);
    }

    class Rectangle : IArea
    {
        public void area(double a, double b)
        {
            double ar;
            ar = a * b;
            Console.WriteLine("the area of rectangle is :" + ar);
        }
    }

    class Circle : IArea
    {
        static double PI = 3.14;
        public void area(double a, double b)
        {
            double ar;
            ar = PI * a * a;
            Console.WriteLine("the Area of Circle is :" + ar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IArea a = new Rectangle();
            a.area(5, 6);
            a = new Circle();
            a.area(7, 0);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class Address
    {
        public string street, city, state;

        public Address(string street, string city, string state)
        {
            this.street = street;
            this.city = city;
            this.state = state;
        }

    }
     class Pupil
    {
        int rollno;
        string name;
        static int batch = 2020;
        static string course="B.tech";
        Address addr;

        public Pupil(int rollno,string name,Address addr)
        {
            this.addr = addr;
            this.rollno = rollno;
            this.addr = addr;
            this.name = name;//Aggregation-->has a relationship
        }
        public void display()
        {
          Console.WriteLine(rollno + " " + name + " "
          + addr.street + " " + addr.city + " " + addr.state);
        }
    }
    class AggregationDemo
    {
        static void Main()
        {
            Address a1 = new Address("Indira Nagar", "Benguluru",
                "Kranataka");
            Pupil p1 = new Pupil(101,"Mike", a1);
            p1.display();
            Console.ReadKey();
        }
    }
}

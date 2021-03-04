using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class StudentDemo
    {
        static void Main()
        {
            Students s1 = new Students(101, "Marry");

            //s1.Name = "Steve"; //complilation error
            // s1.Rollno = 100;

            s1.Course = "Computer Science";  //accessing write only property

            s1.City = "Benguluru";          //store value in auto-implemented property

            Console.WriteLine(s1.Rollno + " " + s1.Name);

           // Console.WriteLine(s1.Course);//complie error-trying to access write only property

            s1.display();
            Console.WriteLine(s1.City);
            Console.ReadKey();
         }
    }
}

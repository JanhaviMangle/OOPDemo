using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Read only / write only properties */
namespace OOPSDemo1
{
    class Students
    {
        private int rollno;
        private string name;
        private string course;
        private string city;

        public Students(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        public int Rollno { get => rollno; }
        public string Name { get {return name; } }

        public string Course { set { course = value; } }

        //Auto Implemented property
        public string City {  get; set; }

        public void display()
        {
            Console.WriteLine(course);
        }
    }
}

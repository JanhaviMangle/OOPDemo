﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printPerson()
        {
            Console.WriteLine("Name    :" + name);
            Console.WriteLine("Age     :" + age);
        }
    }
    class Staff:Person
    {
        protected int staff_id;
        protected long staff_salary;

        public Staff(int staff_id, long staff_salary,string 
                     name,int age):base(name,age)
        {
            this.staff_id = staff_id;
            this.staff_salary = staff_salary;
        }
        public void printStaff()
        {
            Console.WriteLine("Staff_id    :" + staff_id);
            base.printPerson(); //calling base class method.
            Console.WriteLine("Staff Salary    :" + staff_salary);
            
        }
    }
    class Student:Person
    {
        protected int rollno;
        protected double fees;

        public Student(int rollno, double fees,string name,
            int age):base(name,age)
        {
            this.rollno = rollno;
            this.fees = fees;
        }
        public void printStudent()
        {
            Console.WriteLine("Student Id    :" + rollno);
            base.printPerson(); 
            Console.WriteLine("Student fees    :" + fees);
            
        }
    }
    class HierarchicalDemo
    {
        static void Main()
        {
            Staff s1 = new Staff(1001,5000, "Alex",30);
            Student c1 = new Student(100, 1500, "John", 19);

            s1.printStaff();
            c1.printStudent();
            Console.ReadKey();
        }
    }
}

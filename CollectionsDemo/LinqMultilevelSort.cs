﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    //Linq ThenBy & Linq ThenByDescending --Multi level sorting
    class LinqMultilevelSort
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var MS = Student1.GetAllStudents()
                              .OrderBy(x => x.Branch) //first level sort
                              .ThenByDescending(y => y.FirstName) //second level sort
                              .ToList();

            foreach (var student in MS)
            {
                Console.WriteLine(student.Branch + " - " + student.FirstName);
            }
            Console.ReadKey();
        }
    }
}

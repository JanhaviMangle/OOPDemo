using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqJoin
    {
        public int ID { get; set; }
        public String AddressLine { get; set; }
        public static List<Address> GetAllAddresses()
        {
            return new List<Address>()
            {
                new Address{ID=1,AddressLine="Bengaluru"},
                new Address{ID=2,AddressLine="Hyderabad"},
                new Address{ID=3,AddressLine="Secunderabad"},
                new Address{ID=4,AddressLine="Delhi"},
                new Address{ID=5,AddressLine="Chennai"},
                new Address{ID=6,AddressLine="Mumbai"},
                new Address{ID=7,AddressLine="Pune"},
                new Address{ID=8,AddressLine="Calcutta"},



            };

        }




        static void Main(string[] args)
        {
            var JoinUsingMS = Employee1.GetAllEmployees() //Outer Data Source
                           .Join(
                           Address.GetAllAddress(),  //Inner Data Source
                           employee => employee.AddressId, //Inner Key Selector
                           address => address.ID, //Outer Key selector
                           (employee, address) => new //Projecting the data into a result set
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();

            Console.WriteLine("Name \t Address");
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine(employee.EmployeeName + "\t" + employee.AddressLine);
            }
            Console.ReadLine();

            var JoinUsingQS = (from emp in Employee1.GetAllEmployees()
                               join address in Address.GetAllAddress()
                               on emp.AddressId equals address.ID
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();
            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    sealed public class Bank
    {
        public void deposit()
        {
            Console.WriteLine("Depositing Amount");
        }
    }

    public class CooPBank //: Bank
    {
        public void pigmyDeposit()
        {
            Console.WriteLine("Depositing pigmy amount");
        }
    }
    class SealedClassDemo
    {

    }
}

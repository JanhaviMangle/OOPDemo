using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class RBI
    {
        const float RATE_RBI = 6.5f;

        public float calculateBalanceRBI(int amount,int years)
        {
            return amount+((amount*RATE_RBI*years)/100);
        }
    }
    class SBI : RBI
    {
        const float RATE_SBI = 7f;

        public float calculateBalanceSBI(int amount, int years)
        {
            return amount + ((amount * RATE_SBI * years) / 100);
        }
    }
    class Canara : SBI
    {
        const float RATE_CANARA = 7f;

        public float calculateBalanceCanara(int amount, int years)
        {
            return amount + ((amount * RATE_CANARA * years) / 100);
        }
    }
    class MultiLevelBank
    {
        static void Main()
        {
            Canara c1 = new Canara();
            Console.WriteLine("enter the amount you want to invest");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("specify duration in years:");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("maturity amount as per Canara bank:"
                +c1.calculateBalanceCanara(amount, years));

            Console.WriteLine("maturity amount as per SBI:"
               + c1.calculateBalanceSBI(amount, years));

            Console.WriteLine("maturity amount as per RBI:"
                +c1.calculateBalanceCanara(amount, years));

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class Software
    {
        public void update()
        {
            Console.WriteLine("Software Updating.......");
        }
        public void install()
        {
            Console.WriteLine("Software Installing.......");
        }
    }
    class ApplicationSoftware:Software
    {
        public new void install()
        {
            Console.WriteLine("Application software Installing.......");
        }
            
        public  void run()
        {
            Console.WriteLine("application software runnig.........");
        }
    }
    class SystemSoftware:Software
    {
        public void run()
        {
            Console.WriteLine("System software running........");
        }
    }
    class MethodHidingDemo1
    {
        static void Main()
        {
            ApplicationSoftware s1 = new ApplicationSoftware();
            s1.install(); //derived class is running
            s1.update();
            s1.run();
           

            SystemSoftware s2 = new SystemSoftware();
            s2.install();
            s2.update();
            s2.run();
            Console.ReadKey();
        }
    }
}

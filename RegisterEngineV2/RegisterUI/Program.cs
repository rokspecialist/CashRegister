using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest();
            //PlayGround();
        }
        static void RunTest()
        {
            RegisterEngineV2.Register reg = new RegisterEngineV2.Register();
            reg.Scan("1", 10);
            reg.Scan("5", 4);
            reg.Scan("4", 3.5f);
            reg.Scan("C1", 1);
            //reg.Scan("C2", 1);

            Console.WriteLine(reg.GetBill());
            Console.ReadLine();
        }

        static void PlayGround()
        {
            Console.WriteLine(6 / 3);
            Console.ReadLine();

        }
    }
}

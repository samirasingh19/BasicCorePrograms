using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public static void DisplaySwapedNumbers()
        {
            int a = 5, b = 10;
                Console.WriteLine("Before swap a = " + a + " b = " + b);
            a = a * b; a = 50;
            b = a / b; b = 5;
            a = a / b; a = 10;
            Console.WriteLine("After swap a = " + a + " b = " + b);
        }
    }
}

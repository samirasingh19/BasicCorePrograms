using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndReminder
    {
        public static void FindQuotientAndReminder()
        {
            int dividend = 35, divisor = 5;


                int reminder = dividend % divisor;
            int Quotient = dividend / divisor;

            Console.WriteLine("The dividend {0} and dicisor {1} ", dividend, divisor);
            Console.WriteLine("The quotient is " + Quotient + " The reminder is " + reminder);
        }
    }
}

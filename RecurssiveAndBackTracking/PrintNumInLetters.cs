using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssiveAndBackTracking
{
    internal class PrintNumInLetters
    {
        public void printNum(int num, string []s)
        {
            if (num == 0)
            {
                return;
            }
            printNum(num / 10, s);
            Console.Write(s[num%10]);
        }
    }
}

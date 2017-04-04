using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OddNumbers
{
    class Submitted
    {
        public static void Run()
        {
            int number = 1;
            while (number < 100)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }

                number++;
            }
        }
    }
}

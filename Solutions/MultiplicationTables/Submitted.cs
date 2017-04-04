using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTables
{
    class Submitted
    {
        public static void Run()
        {
            int n = 12;
            int[] numbers = new int[n];

            String[] numbers2 = new String[numbers.Length];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
                numbers2[i] = Convert.ToString(numbers[i]);

                if (i == 0)
                {
                    Console.Write(numbers2[i].PadLeft(2));
                }
                else
                {
                    Console.Write(numbers2[i].PadLeft(4));
                }
            }

            Console.Write("\n");

            int integer = 2;
            while (integer <= n)
            {
                int y = 0;
                String z;
                for (int x = 0; x < n; x++)
                {
                    y = integer * numbers[x];
                    z = Convert.ToString(y);

                    if (x == 0)
                    {
                        Console.Write(z.PadLeft(2)); //string will be right aligned
                    }

                    else
                    {
                        Console.Write(z.PadLeft(4));
                    }
                }

                Console.Write("\n");
                integer++;
            }
        }
    }
}

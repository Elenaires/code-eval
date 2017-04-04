using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LuckyTickets
{
    class StarAndBar
    {

        public static long Factorial(int N)
        {
            long factorial = 1;
            for (int counter = 1; counter <= N; counter++)
            {
                factorial = factorial * counter;
            }

            return factorial;
        }

        public static void Run(string path)
        {
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                line = file.ReadLine();
                int n = Convert.ToInt32(line);
                int halfOfN = n/2;
                int maxDigit = 9;
                int maxSum = halfOfN * maxDigit;
                int halfofMaxSum = maxSum / 2;

                int arraySize = halfofMaxSum + 1;
        
                long[] arrays = new long[arraySize];
             
                int r = halfOfN - 1;
                for (int x = 0; x <= halfofMaxSum; x++)
                {
                    if (x == 0)
                    {
                        arrays[x] = 1;
                    }

                    else if (x > 0 && x < 10)
                    {
                        arrays[x] = Factorial(x + r) / (Factorial(r) * Factorial(x)); 
                    }

                    else if (x >= 10 && x < 20)
                    {
                        long z = Factorial(x + r);
                        long y = Factorial(x);
                        long a = Factorial(x + r) / (Factorial(r) * Factorial(x));
                        long b = ((Factorial((x - 10) + r) / (Factorial(r) * Factorial(x - 10))));
                        arrays[x] = (Factorial(x + r) / (Factorial(r) * Factorial(x))) - (halfOfN * ((Factorial((x - 10) + r) / (Factorial(r) * Factorial(x - 10)))));
                    }

                    else if (x >= 20 && x < 30)
                    {
                        arrays[x] = (Factorial(x + r) / (Factorial(r) * Factorial(x))) - (halfOfN * ((Factorial((x - 10) + r) / (Factorial(r) * Factorial(x - 10)))))
                            + ((Factorial(halfOfN) / (2 * Factorial(halfOfN))) * (Factorial((x - 20) + r) / (Factorial(r) * Factorial(x - 20)))); 
                    }

                    else if (x >= 30 && x < 40)
                    {
                        arrays[x] = (Factorial(x + r) / (Factorial(r) * Factorial(x))) - (halfOfN * ((Factorial((x - 10) + r) / (Factorial(r) * Factorial(x - 10)))))
                            + ((Factorial(halfOfN) / (2 * Factorial(halfOfN))) * (Factorial((x - 20) + r) / (Factorial(r) * Factorial(x - 20))))
                            - ((Factorial(halfOfN) / (3 * Factorial(halfOfN))) * (Factorial((x - 30) + r) / (Factorial(r) * Factorial(x - 30)))); 
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }

                    else if (x >= 10 && x < 20)
                    {
                    }
                }

                long sum = 0;
                if (halfOfN % 2 == 0)
                {
                    for (int index = 0; index < arrays.Length; index++)
                    {
                        if (index < arrays.Length - 1)
                        {
                            arrays[index] = arrays[index] * arrays[index];
                            arrays[index] = arrays[index] * 2;
                        }

                        else if (index == arrays.Length - 1)
                        {
                            arrays[index] = arrays[index] * arrays[index];
                        }
                    }

                    sum = arrays.Sum();
                }

                else if (halfOfN % 2 == 1)
                {
                    for (int index = 0; index < arrays.Length; index++)
                    {
                        arrays[index] = arrays[index] * arrays[index];
                        arrays[index] = arrays[index] * 2;
                    }

                    sum = arrays.Sum();
                }

                Console.WriteLine(sum);

            }
        }
    }
}

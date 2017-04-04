using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LuckyTickets
{
    class StarAndBar_Improved
    {

        public static ulong Factorial(ulong N, ulong R)
        {
            ulong factorial = 1;
            for (ulong counter = Convert.ToUInt64(N - R); counter <= Convert.ToUInt64(N); counter++)
            {
                factorial = factorial * counter;
            }

            return factorial;
        }

        public static ulong Factorial2(ulong N)
        {
            ulong factorial = 1;
            for (ulong counter = Convert.ToUInt64(1); counter <= Convert.ToUInt64(N); counter++)
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
                while ((line = file.ReadLine()) != null)
                {
                    ulong n = Convert.ToUInt64(line);
                    ulong halfOfN = n / 2;
                    ulong maxDigit = 9;
                    ulong maxSum = Convert.ToUInt64(halfOfN * maxDigit);

                    ulong r = Convert.ToUInt64(n - 1);
                    ulong R = r - 1;
                    ulong N = Convert.ToUInt64(maxSum + r);

                    ulong answer = 0;

                    if (maxSum == 9)
                    {
                        answer = 10;
                    }

                    if (maxSum == 18)
                    {

                        //int a = Factorial(21, R);
                        //int b = Factorial2(r);
                        //int c = Factorial2(n) / (Factorial2(1) * Factorial2(n-1));
                        //int d = (Factorial(11, R) / (Factorial2(r)));

                        answer = Factorial(21, R) / Factorial2(r)
                            - (Factorial2(n) / (Factorial2(1) * Factorial2(n - 1)) * (Factorial(11, R) / (Factorial2(r))));
                    }

                    else if (maxSum == 27)
                    {
                        answer = Factorial(maxSum + r, R) / Factorial2(r)
                           - (Factorial2(n) / (Factorial2(1) * Factorial2(n - 1)) * (Factorial(maxSum - 10 + r, R) / (Factorial2(r))))
                           + (Factorial2(n) / (Factorial2(2) * Factorial2(n - 2)) * (Factorial(maxSum - 20 + r, R) / (Factorial2(r))));
                    }

                    else if (maxSum == 36)
                    {
                        //long e = Factorial(maxSum + r, R) / Factorial2(r);
                        //long f = (Factorial2(n) / (Factorial2(1) * Factorial2(n - 1)) * (Factorial(maxSum - 10 + r, R) / (Factorial2(r))));
                        //long f2 =(Factorial(maxSum - 10 + r, R) / (Factorial2(r)));
                        //long g = (Factorial2(n) / (Factorial2(2) * Factorial2(n - 2)) * (Factorial(maxSum - 20 + r, R) / (Factorial2(r))));
                        //long h = (Factorial2(n) / (Factorial2(3) * Factorial2(n - 3)) * (Factorial(maxSum - 30 + r, R) / (Factorial2(r))));

                        answer = Factorial(maxSum + r, R) / Factorial2(r)
                           - (Factorial2(n) / (Factorial2(1) * Factorial2(n - 1)) * (Factorial(maxSum - 10 + r, R) / (Factorial2(r))))
                           + (Factorial2(n) / (Factorial2(2) * Factorial2(n - 2)) * (Factorial(maxSum - 20 + r, R) / (Factorial2(r))))
                           - (Factorial2(n) / (Factorial2(3) * Factorial2(n - 3)) * (Factorial(maxSum - 30 + r, R) / (Factorial2(r))));
                    }

                    else if (maxSum == 45)
                    {
                        answer = Factorial(maxSum + r, R) / Factorial2(r)
                           - (Factorial2(n) / (Factorial2(1) * Factorial2(n - 1)) * (Factorial(maxSum - 10 + r, R) / (Factorial2(r))))
                           + (Factorial2(n) / (Factorial2(2) * Factorial2(n - 2)) * (Factorial(maxSum - 20 + r, R) / (Factorial2(r))))
                           - (Factorial2(n) / (Factorial2(3) * Factorial2(n - 3)) * (Factorial(maxSum - 30 + r, R) / (Factorial2(r))))
                           + (Factorial2(n) / (Factorial2(4) * Factorial2(n - 4)) * (Factorial(maxSum - 40 + r, R) / (Factorial2(r))));
                    }

                    else if (maxSum == 54)
                    {
                        ulong a = Factorial(maxSum + r, R) / Factorial2(r);
                        ulong b = (Factorial2(n) / (Factorial2(1) * Factorial2(n - 1)) * (Factorial(maxSum - 10 + r, R) / (Factorial2(r))));
                        ulong c = (Factorial2(n) / (Factorial2(2) * Factorial2(n - 2)) * (Factorial(maxSum - 20 + r, R) / (Factorial2(r))));
                        ulong d = (Factorial2(n) / (Factorial2(3) * Factorial2(n - 3)) * (Factorial(maxSum - 30 + r, R) / (Factorial2(r))));
                        ulong e = (Factorial2(n) / (Factorial2(4) * Factorial2(n - 4)) * (Factorial(maxSum - 40 + r, R) / (Factorial2(r))));
                        ulong f = (Factorial2(n) / (Factorial2(5) * Factorial2(n - 5)) * (Factorial(maxSum - 50 + r, R) / (Factorial2(r))));
                    }
                    Console.WriteLine(answer);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LuckyTickets
{
    class Submitted
    {
        public static void Run(string path)
        {
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {

                    int digit = Convert.ToInt32(line);

                    string min = string.Empty;
                    for (int y = 1; y <= digit; y++)
                    {
                        min += "1";
                    }

                    int minDigit = Convert.ToInt32(min);

                    int b = 9;
                    int maxDigit = minDigit * b;

                    int runningDigit = 0;
                    string stringDigit = string.Empty;
                    int sum = 0;

                    
                    for (int x = 0; x < maxDigit; x++)
                    {
                        runningDigit += 1;

                        stringDigit = Convert.ToString(runningDigit);
                        stringDigit = stringDigit.PadLeft(digit, '0');

                        int[] singleDigits = new int[stringDigit.Length];
                        for (int z = 0; z < stringDigit.Length; z++)
                        {
                            singleDigits[z] = Convert.ToInt32(stringDigit[z]) - 48;
                        }

                        int digit2 = digit / 2;
                        int sumFirstHalf = 0;
                        for (int a = 0; a < digit2; a++)
                        {
                            sumFirstHalf += singleDigits[a];
                        }

                        int sumSecondHalf = 0;
                        for (int a = digit2; a < singleDigits.Length; a++)
                        {
                            sumSecondHalf += singleDigits[a];
                        }

                        if (sumFirstHalf == sumSecondHalf)
                        {
                            sum += 1;
                        }
                    }

                    Console.WriteLine(sum + 1);
                }
            }
            
        }
    }
}

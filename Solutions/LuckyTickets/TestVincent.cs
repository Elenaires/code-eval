using System;
using System.IO;
namespace LuckyTickets
{
    public class TestVincent
    {
        public static void GetResult()
        {
            //string line;
            //using (StreamReader file = new StreamReader())
            {
                //while ((line = file.ReadLine()) != null)
                {

                    int n = 6;// Convert.ToInt32(line);

                    var halfOfN = n / 2;
                    var maxDigit = 9;

                    var arraySize = halfOfN * maxDigit + 1;
                    var array = new int[arraySize];

                    var max = Math.Pow(10, halfOfN) - 1;

                    for (var i = 0; i <= max; i++)
                    {
                        var index = GetSumOfDigits(i);
                        array[index]++;
                    }

                    PrintArray(array);

                    var numberOfWays = 0.00;
                    for (var i = 0; i < array.Length; i++)
                    {
                        numberOfWays += array[i] * array[i];
                    }

                    Console.WriteLine(numberOfWays);
                }
            }
        }

        private static int GetSumOfDigits(int digit)
        {
            var sum = 0;
            var digitString = digit.ToString();
            for (var i = 0; i < digitString.Length; i++)
            {
                sum += Int32.Parse(digitString[i].ToString());
            }
            return sum;
        }

        private static void PrintArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Sum {0}:: {1}", i, array[i]);
            }
        }
    }
}

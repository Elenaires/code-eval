using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace SumOfDigits
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
                    int[] integers = new int[line.Length];
                    int sum = 0;

                    for (int x = 0; x < line.Length; x++)
                    {
                        integers[x] = (int)Char.GetNumericValue(line[x]);
                        sum += integers[x];
                    }

                    Console.WriteLine(sum);
                }
            }
        }
    }
}

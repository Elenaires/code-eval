using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solutions.SumOfIntegers
{
    class Submitted
    {
        public static void Run(string path)
        {
            string line;
            using (StreamReader file = new StreamReader(path))
            {

                int value = 0;
                int sum = 0;
                while ((line = file.ReadLine()) != null)
                {
                    value = Convert.ToInt32(line);
                    sum += value;
                }

                Console.WriteLine(sum);
            }
        }
    }
}

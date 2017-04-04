using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleSorting
{
    class Submitted
    {
        public static void Run(string path)
        {
            String line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    String[] split = line.Split(' ');
                    double[] numbers = new double[split.Length];

                    for (int x = 0; x < split.Length; x++)
                    {
                        numbers[x] = Double.Parse(split[x]);
                    }

                    bool doBreak = true;
                    double temp = 0;
                    for (int x = 0; x < numbers.Length; x++)
                    {
                        doBreak = true; //early escape
                        for (int y = 0; y < numbers.Length - 1; y++)
                        {
                            if (numbers[y] > numbers[y + 1])
                            {
                                temp = numbers[y + 1];
                                numbers[y + 1] = numbers[y];
                                numbers[y] = temp;
                                doBreak = false; //early escape
                            }
                        }
                        if (doBreak) { break; /*early escape*/ }
                    }

                    for (int x = 0; x < numbers.Length; x++)
                    {
                        Console.Write(numbers[x].ToString("0.000") + " ");
                    }

                    Console.Write("\n");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solutions.HighestScore
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
                    string[] split = line.Split('|');

                    string[] a1 = split[0].Split(' ');
                    int[] intA1 = new int[a1.Length - 1];
                    for (int x = 0; x < intA1.Length; x++)
                    {
                        intA1[x] = Convert.ToInt32(a1[x]);
                    }

                    string[] a2 = split[1].Split(' ');
                    int[] intA2 = new int[a1.Length - 1];
                    for (int x = 0; x < intA2.Length; x++)
                    {
                        intA2[x] = Convert.ToInt32(a2[x + 1]);
                    }

                    string[] a3 = split[2].Split(' ');
                    int[] intA3 = new int[a1.Length - 1];
                    for (int x = 0; x < intA3.Length; x++)
                    {
                        intA3[x] = Convert.ToInt32(a3[x + 1]);
                    }


                    int maxSum = 0;

                    for (int x = 0; x < intA1.Length; x++)
                    {
                        maxSum = Math.Max(intA1[x], Math.Max(intA2[x], intA3[x]));
                        Console.Write(maxSum + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solutions.HighestScore
{
    class Submitted2
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
                    int length = a1.Length - 1;
                    int interval = length + 1;

                    string[] split2 = line.Split(' ');
                    int[] intSplit2 = new int[split2.Length];

                    int count = 0;
                    for (int x = 0; x < intSplit2.Length; x++)
                    {
                        
                        
                        if (x == length || x == length + (count * interval))
                        {
                            count++;
                            continue;
                        }

                        else
                        {
                            intSplit2[x] = Convert.ToInt32(split2[x]);
                        }
                    }

                    int count0 = 0;
                    int y = 0;
                    while (count0 < length)
                    {

                        int maxSum = 0;
                        int count1 = 0;

                        while (count1 < split.Length)
                        {
                            
                            if (maxSum > intSplit2[y] &&  maxSum != 0)
                            {
                                maxSum = maxSum;
                            }

                            else
                            {
                                maxSum = intSplit2[y];
                            }
                            y += interval;
                            count1++;
                        }

                        Console.Write(maxSum + " ");
                        count0++;
                        y = 0 + count0;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

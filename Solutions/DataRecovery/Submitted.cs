using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataRecovery
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
                    if (line == String.Empty)
                    {
                        continue;
                    }

                    String[] split = line.Split(';');
                    String[] words = split[0].Split(' ');
                    String[] sequence = split[1].Split(' ');
                    String[] words2 = new String[words.Length];
                    int[] sequence2 = new int[sequence.Length + 1];

                    int sum = 0;
                    for (int x = 0; x < sequence.Length; x++)
                    {
                        sequence2[x] = Int32.Parse(sequence[x]);
                        sum += sequence2[x];
                    }

                    int n = sequence2.Length;
                    sequence2[n - 1] = (n * (n + 1) / 2) - sum;

                    for (int i = 0; i < words.Length; i++)
                    {
                        words2[sequence2[i] - 1] = words[i];
                    }

                    for (int y = 0; y < words2.Length; y++)
                    {
                        Console.Write(words2[y] + " ");
                    }

                    Console.Write("\n");
                }
            }
        }
    }
}

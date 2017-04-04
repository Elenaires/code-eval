using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedWords
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

                    String[] words = line.Split(' ');
                    String[] words2 = new String[words.Length];

                    int x = words.Length - 1;
                    for (int i = 0; i < words2.Length; i++)
                    {
                        words2[i] = words[x];
                        x--;
                    }

                    for (int i = 0; i < words2.Length; i++)
                    {
                        if (i == words2.Length - 1)
                        {
                            Console.Write(words2[i]);
                        }
                        else
                        {
                            Console.Write(words2[i] + " ");
                        }
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}

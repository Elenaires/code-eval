using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WineTasting
{
    class Vincent
    {
        const int arrayOffset = 1;
        const int asciiOffset = 97;
        public static void Run(string path)
        {
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line == String.Empty)
                    {
                        continue;
                    }

                    string[] split = line.Split(' ');
                    Solve(split);
                    Console.WriteLine();
                }
            }
        }

        private static void Solve(string[] split)
        {
            // The characters part after |
            int comparerIndex = split.Length - arrayOffset;
            var characters = split[comparerIndex];
            var comparer = new int[26];
            SetComparerArray(characters.ToLower(), comparer);
            int countFalse = 0;

            // Wines
            for (int p = 0; p < split.Length - 2; p++)
            {
                var comparee = new int[26];

                var words = split[p].ToLower();
                for (var i = 0; i < words.Length; i++)
                {
                    var ascii = words[i] - asciiOffset;
                    comparee[ascii]++;
                }

                // Print answer
                var shouldPrint = true;
                for (var i = 0; i < characters.Length; i++)
                {
                    var ascii = characters[i] - asciiOffset;
                    if (comparee[ascii] < comparer[ascii])
                    {
                        shouldPrint = false;
                    }
                }

                if (shouldPrint)
                {
                    Console.Write(split[p] + " ");
                }

                else
                {
                    countFalse++;
                }

                if (countFalse == split.Length - 2)
                {
                    Console.Write("False");
                }
               
            }            
        }

        private static void SetComparerArray(string characters, int[] comparer)
        {
            for (var i = 0; i < characters.Length; i++)
            {
                var ascii = characters[i] - asciiOffset;
                comparer[ascii]++;
            }
        }
    }
}


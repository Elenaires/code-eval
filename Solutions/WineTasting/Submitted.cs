using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WineTasting
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

                    if (line == String.Empty)
                    {
                        continue;
                    }

                    string[] split = line.Split(' ');


                
                    //split[0] = wine
                    //splt[1] = wine2
                    //split[2] = |
                    //split[3] = ann

                    int count = 0;
                    int countFalse = 0;
                    for (int z = 0; z < split.Length - 2; z++)
                    {
                        string original = split[z];

                        char[] letters = split[z].ToCharArray();
                        for (int a = 0; a < letters.Length; a++)
                        {
                            char letter = letters[a];
                        }

                        for (int x = 0; x < split[split.Length - 1].Length; x++)
                        {
                            for (int y = 0; y < letters.Length; y++)
                            {
                                if (letters[y] == split[split.Length - 1][x])
                                {
                                    count++;
                                    letters[y] = '1';
                                    break;
                                }

                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (count == split[split.Length - 1].Length)
                        {
                            Console.Write(original + " ");
                        }

                        else
                        {
                            countFalse++;
                        }

                        count = 0;

                        if (countFalse == split.Length - 2)
                        {
                            Console.Write("False");
                        }

                    }

                    Console.WriteLine();
                }
            }

        }

    }
}


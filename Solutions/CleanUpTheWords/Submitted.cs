using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CleanUpTheWords
{
    public class Submitted
    {
        public static void Run(string path)
        {
            String line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {

                    byte[] asciiBytes = Encoding.ASCII.GetBytes(line);

                    for (int x = 0; x < asciiBytes.Length; x++)
                    {
                        if (asciiBytes[x] < 65 || asciiBytes[x] > 90 && asciiBytes[x] < 97 || asciiBytes[x] > 122)
                        {
                            if (x == 0)
                            {
                                continue;
                            }

                            else if (asciiBytes[x - 1] >= 65 && asciiBytes[x - 1] <= 90 || asciiBytes[x - 1] >= 97 && asciiBytes[x - 1] <= 122)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                continue;
                            }
                        }

                        else if (asciiBytes[x] >= 65 && asciiBytes[x] <= 90 || asciiBytes[x] >= 97 && asciiBytes[x] <= 122)
                        {
                            Char ch = ((char)(asciiBytes[x]));
                            Console.Write(Char.ToLower(ch));
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}


                            


              


                

              



            
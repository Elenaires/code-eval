using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solutions.LowerCase
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

                    byte[] asciiBytes = Encoding.ASCII.GetBytes(line);


                    for (int x = 0; x < asciiBytes.Length; x++)
                    {
                        if (asciiBytes[x] == 32)
                        {
                            Console.Write(Convert.ToChar(asciiBytes[x]));
                        }

                        else if (asciiBytes[x] >= 65 && asciiBytes[x] <= 90)
                        {
                            int y = Convert.ToInt32(asciiBytes[x]) + 32;
                            char ch = Convert.ToChar(y);
                            Console.Write(ch);
                        }

                        else
                        {
                            Console.Write(Convert.ToChar(asciiBytes[x]));
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

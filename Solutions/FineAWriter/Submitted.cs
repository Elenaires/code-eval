using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FineAWriter
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

                    string[] split2 = split[1].Split(' ');
                    int number;
                    char character;
                    for (int x = 1; x < split2.Length; x++)
                    {
                        number = Int32.Parse(split2[x]);
                        character = Convert.ToChar(split[0][number - 1]);
                        
                        Console.Write(character);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

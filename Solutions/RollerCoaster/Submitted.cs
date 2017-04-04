using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RollerCoaster
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
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(line);

                    bool val = true;
                    for (int x = 0; x < asciiBytes.Length; x++)
                    {
                        if (x == 0)
                        {
                            Char ch = (char)(asciiBytes[x]);
                            Console.Write(Char.ToUpper(ch));
                        }

                        else if (asciiBytes[x] >= 65 && asciiBytes[x] <= 90 || asciiBytes[x] >= 97 && asciiBytes[x] <= 122)
                        {
                            if (val)
                            {
                                Char ch = (char)(asciiBytes[x]);
                                Console.Write(Char.ToLower(ch));
                            }

                            else if (!val)
                            {
                                Char ch = (char)(asciiBytes[x]);
                                Console.Write(Char.ToUpper(ch));
                            }

                            val = !val;
                        }

                        else
                        {
                            Char ch = (char)(asciiBytes[x]);
                            Console.Write(ch);
                        }
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}

                      
                
             
              
                   
     
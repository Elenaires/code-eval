///********************************************
// * 
// * Vince's solution - partially correct (35%)
// *
// ********************************************/
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace MaxRangeSum
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            String line;
//            using (StreamReader file = new StreamReader(@"C:\Source\Sample.txt"))
//            {
                
//                while ((line = file.ReadLine()) != null)
//                {
//                    int lastIndex = 0;
//                    int largest = int.MinValue;

//                    string[] split = line.Split(';');
//                    var n = int.Parse(split[0]);
//                    var input = split[1].Split(' ');        
                    
//                    // Change input to integers
//                    var integers = new int[input.Length];
//                    for(var i = 0; i < input.Length; i++) 
//                    {
//                        integers[i] = int.Parse(input[i]);
//                    }


//                    // Main logic
//                    int start = 0;
//                    int end = start + n;

//                    while (end <= input.Length)
//                    {
//                        if (n == 1)
//                        {
//                            if (largest < integers[start])
//                            {
//                                largest = integers[start];
//                            }
//                        }

//                        if (start == end - 1)
//                        {
//                            lastIndex++;
                            
//                            start = end - n + 1;
//                            end = start + n;
//                            continue;
//                        }

//                        var sumLocationIndex = end - n;
//                        integers[sumLocationIndex] += integers[start + 1];

//                        if (largest < integers[sumLocationIndex])
//                        {
//                            largest = integers[sumLocationIndex];
//                        }
//                        start++;

//                    }

//                    // Print result
//                    //for (var i = 0; i < lastIndex; i++)
//                    //{
//                    //    Console.Write("{0} ", integers[i]);
//                    //}
//                    Console.Write("{0} ", largest <0? 0: largest);
//                    Console.WriteLine();

//                }
//            }
//        }
//    }
//}

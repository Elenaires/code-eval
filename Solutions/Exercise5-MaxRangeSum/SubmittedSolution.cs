//1)Internet solution - accepted by codeeval

//using System;
//using System.IO;
//using System.Linq;
//
//class MaxRangeSum
//{
//    public static void Main(string[] args)
//    {
//        using (StreamReader reader = new StreamReader(@"C:\Source\Sample.txt"))
//        {
//            while (!reader.EndOfStream)
//            {
//                string line = reader.ReadLine();
//                if (null == line)
//                    continue;
//
//                string[] inputs = line.Split(';');
//                int n = Int32.Parse(inputs[0]);
//                int[] vals = inputs[1].Split().Select(x => Int32.Parse(x)).ToArray();
//
//                int maxGain = -101;
//                for (int i = 0; i < vals.Length - n + 1; i++)
//                {
//                    int subGain = vals.Skip(i).Take(n).Sum();
//                    if (subGain > maxGain)
//                        maxGain = subGain;
//                }
//
//                if (maxGain > 0)
//                    Console.WriteLine(maxGain);
//                else
//                    Console.WriteLine(0);
//            }
//        }
//    }
//}











// Vince's solution - partially correct (35%)
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//
//namespace MaxRangeSum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            String line;
//            using (StreamReader file = new StreamReader(@"C:\Source\Sample.txt"))
//            {
//                
//                while ((line = file.ReadLine()) != null)
//                {
//                    int lastIndex = 0;
//                    int largest = int.MinValue;
//
//                    string[] split = line.Split(';');
//                    var n = int.Parse(split[0]);
//                    var input = split[1].Split(' ');        
//                    
//                    // Change input to integers
//                    var integers = new int[input.Length];
//                    for(var i = 0; i < input.Length; i++) 
//                    {
//                        integers[i] = int.Parse(input[i]);
//                    }
//
//
//                    // Main logic
//                    int start = 0;
//                    int end = start + n;
//
//                    while (end <= input.Length)
//                    {
//                        if (n == 1)
//                        {
//                            if (largest < integers[start])
//                            {
//                                largest = integers[start];
//                            }
//                        }
//
//                        if (start == end - 1)
//                        {
//                            lastIndex++;
//                            
//                            start = end - n + 1;
//                            end = start + n;
//                            continue;
//                        }
//
//                        var sumLocationIndex = end - n;
//                        integers[sumLocationIndex] += integers[start + 1];
//
//                        if (largest < integers[sumLocationIndex])
//                        {
//                            largest = integers[sumLocationIndex];
//                        }
//                        start++;
//
//                    }
//
//                    // Print result
//                    //for (var i = 0; i < lastIndex; i++)
//                    //{
//                    //    Console.Write("{0} ", integers[i]);
//                    //}
//                    Console.Write("{0} ", largest <0? 0: largest);
//                    Console.WriteLine();
//
//                }
//            }
//        }
//    }
//}



























//HC's solution - correct
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//namespace MaxRangeSum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//
//            String line;
//            using (StreamReader file = new StreamReader(@"C:\Source\MaxRangeSum.txt"))
//            {
//                while ((line = file.ReadLine()) != null)
//                {
//
//
//                    string[] split = line.Split(';', ' ');
//
//                    int noOfDays = Convert.ToInt32(split[0]);
//                    int[] integers = new int[split.Length];
//                    int start = 1;
//                    int end = start + noOfDays;
//
//                    integers[end - noOfDays] = Convert.ToInt32(split[end - noOfDays]);
//                    while (end <= split.Length)
//                    {
//                        //for (int i = 0; i < split.Length; i++)
//                        //{
//                        //integers[i] = Convert.ToInt32(split[i]);
//
//
//                        if (start == end - 1)
//                        {
//                            start = end - noOfDays + 1;
//
//                            //Console.WriteLine(integers[end - noOfDays]);
//                           
//
//                            end = start + noOfDays;
//
//                            //if (end - noOfDays < split.Length-1)
//                            if((end - 1) < split.Length)
//                            {
//                                integers[end - noOfDays] = Convert.ToInt32(split[end - noOfDays]);
//                            }
//
//
//                        }
//
//                        else
//                        {
//                            //integers[end - noOfDays] = Convert.ToInt32(split[end - noOfDays]);
//                            integers[end - noOfDays] += Convert.ToInt32(split[start + 1]);
//                            start++;
//                        }
//
//                        //}
//                    }
//
//                    Console.WriteLine(integers.Max());
//                }
//            }
//        }
//    }
//}


        //int lengthOfSplit = split.Length;
        //int noOfSets = lengthOfSplit - noOfDays;
        //
        //int sum = 0;
        //while ()
        // {
        //    
        //    for (int y = 0; y <= noOfSets; y++)
        //    {
        //
        //        int[] x = split[x+1];
        //
        //    for (x = 0; x <= noOfDays; x++)
        //    {   
        //        int integer = Convert.ToInt32(split[x]);
        //        sum += integer;
        //        split[x+1];
        //    }








//    }
//}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxRangeSum
{
    public class Submitted
    {
        public static void Run(string path)
        {
            const int arrayIndexOffset = 1;
            String line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] split = line.Split(';');
                    int noOfDays = Convert.ToInt32(split[0]);
                    String[] numbers = split[1].Split(' ');

                    int[] integers = new int[numbers.Length];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        integers[i] = Int32.Parse(numbers[i]);
                    }

                    int start = 0;
                    int end = start + (noOfDays - arrayIndexOffset);
                    int noOfSets = (integers.Length) - end;
                    List<int> myList = new List<int>();

                    int y = 0;
                    int x = 1;
                    while (x <= noOfSets)
                    {
                        int sum = 0;
                        while (y <= end)
                        {
                            sum += integers[start];
                            start++;
                            y++;
                        }

                        myList.Add(sum);
                        start = start - noOfDays + arrayIndexOffset;
                        y = y - noOfDays + arrayIndexOffset;
                        end++;
                        x++;
                    }

                    if (myList.Max() >= 0)
                    {
                        Console.WriteLine(myList.Max());
                    }

                    else if (myList.Max() < 0)
                    {
                        Console.WriteLine("0");
                    }
                }
            }
        }        
    }
}
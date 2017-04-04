using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TrickOrTreat
{
    class Submitted
    {
        public static void Run (string path)
        {
            string line;

            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] split = line.Split(',');
                    string[] split2;
                    var candies = 0;
                    var factor = 3;
                    var kids = 0;
                    for (int i = 0; i < split.Length-1; i++)
                    {
                        split2 = split[i].Split(':');

                        var value = Int32.Parse(split2[1]);
                        kids += value;
                        candies += value * factor;
                        factor++;

                    }


                    string[] split3 = split[3].Split(':');
                    int houses = Int32.Parse(split3[1]);
                    int sumcandies = candies * houses;

                    if (sumcandies == 0 || kids == 0)
                    {
                        Console.WriteLine("0");

                    }

                    else
                    {
                        int candiesPerKid = sumcandies / kids;

                        Console.WriteLine(candiesPerKid);
                    }
                    //Console.WriteLine(String.Format("{0}", candies * houses));


                }
            }
        }
    }
}

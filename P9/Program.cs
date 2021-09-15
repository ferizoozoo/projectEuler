using System.IO;
using System.Text.RegularExpressions;
using System;

namespace P9
{
    class Program
    {
        static int ProductOfPythagorianTriplet(int sumOfTriplets)
        {
            var squareOfSumOfTriplets = (int)Math.Pow(sumOfTriplets, 1 / 3);

            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 1; i < sumOfTriplets; i++)
            {
                for (int j = 1; j < sumOfTriplets; j++)
                {
                    if (i * j == sumOfTriplets * (i + j - (int)sumOfTriplets / 2))
                    {
                        a = i;
                        b = j;
                        c = sumOfTriplets - (i + j);
                    }
                }
            }

            return a * b * c;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine(ProductOfPythagorianTriplet(1000));
        }
    }
}

using System.Collections.Generic;
using System;
using System.Dynamic;

namespace P5
{
    class Program
    {
        // static bool IsDivisibleByN(int n, int number) => number % n == 0;

        // static HashSet<int> GetDivisorsOfNumber(int number)
        // {
        //     var divisors = new HashSet<int>();

        //     for (int n = 2; n < Math.Pow(number, 0.5); n++)
        //     {
        //         if (IsDivisibleByN(n, number))
        //         {
        //             divisors.Add(n);
        //         }
        //     }

        //     return divisors;
        // }

        static bool IsPrime(long n)
        {
            var isPrime = true;

            if (n == 2 || n == 3)
                return isPrime;

            for (long number = 2; number < Math.Pow(n, 0.5) + 1; number++)
            {
                if (n % number == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        static int MinimumProducts20(int minimumProducts10)
        {
            var result = minimumProducts10;

            for (int number = 11; number < 20; number++)
                if (IsPrime(number))
                    result *= number;

            result *= 2;

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MinimumProducts20(2520));
        }
    }
}

using System;
using System.Globalization;

namespace P3
{
    class Program
    {
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

        static long LargestPrimeFactor(long n)
        {
            var factor = (long)Math.Pow(n, 0.5) + 1;

            while (factor > 0)
            {
                if (IsPrime(factor) && n % factor == 0)
                    return factor;

                factor--;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LargestPrimeFactor(600851475143));
        }
    }
}

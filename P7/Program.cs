using System;

namespace P7
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

        static int GetNthPrimeNumber(int n)
        {
            int counter = 0;
            int number = 1;

            while (counter != n)
            {
                number++;

                if (IsPrime(number))
                    counter++;
            }

            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetNthPrimeNumber(10001));
        }
    }
}

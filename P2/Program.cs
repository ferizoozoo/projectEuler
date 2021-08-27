using System;

namespace P2
{
    class Program
    {
        const long MAXIMUM_VALUE = 4_000_000;
        private static long[] fibonacciSeries = new long[MAXIMUM_VALUE];

        static long Fibonacci(long n)
        {
            if (n <= 2 && n >= 0)
            {
                fibonacciSeries[n] = n;
                return n;
            }

            fibonacciSeries[n] = Fibonacci(n - 2) + Fibonacci(n - 1);
            return fibonacciSeries[n];
        }

        static void Main(string[] args)
        {
            long sumOfEvenValuedTermsInFibonacciSeries = 0;

            int counter = 1;
            long termOfFibonacciSeries = 0;

            while (termOfFibonacciSeries <= MAXIMUM_VALUE)
            {
                if (termOfFibonacciSeries % 2 == 0)
                    sumOfEvenValuedTermsInFibonacciSeries += termOfFibonacciSeries;

                termOfFibonacciSeries = Fibonacci(counter);

                counter++;
            }

            Console.WriteLine(sumOfEvenValuedTermsInFibonacciSeries);
        }
    }
}

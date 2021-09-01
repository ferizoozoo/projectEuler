using System;

namespace P6
{
    class Program
    {
        static long SumOfSquaresOfFirst_N_Numbers(int n)
        {
            long result = 0;

            for (int number = 1; number <= n; number++)
                result += (long)Math.Pow(number, 2);

            return result;
        }

        static long SquareOfSumOfFirst_N_Numbers(int n)
        {
            var sumOfFirst_N_Numbers = 0;

            for (int number = 1; number <= n; number++)
                sumOfFirst_N_Numbers += number;

            return (long)Math.Pow(sumOfFirst_N_Numbers, 2);
        }

        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine(SquareOfSumOfFirst_N_Numbers(n) - SumOfSquaresOfFirst_N_Numbers(n));
        }
    }
}

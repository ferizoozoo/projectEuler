using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1000;
            int sumOfMultiplesOfThreeOrFiveBelowN = 0;

            for (int number = 1; number < N; number++)
            {
                if (number % 3 == 0 || number % 5 == 0)
                    sumOfMultiplesOfThreeOrFiveBelowN += number;
            }

            Console.WriteLine(sumOfMultiplesOfThreeOrFiveBelowN);
        }
    }
}

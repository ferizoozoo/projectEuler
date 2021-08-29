using System.Collections.Generic;
using System;
using System.Linq;

namespace P4
{
    class Program
    {
        static string GetReversedString(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static bool IsPalindrome(int number)
        {
            var numberString = number.ToString();
            return numberString == GetReversedString(numberString);
        }

        static IEnumerable<int> GenerateProductOfThreeDigitNumbers()
        {
            for (int firstNumber = 999; firstNumber >= 100; firstNumber--)
            {
                for (int secondNumber = 999; secondNumber >= 100; secondNumber--)
                    yield return firstNumber * secondNumber;
            }
        }

        static void Main(string[] args)
        {
            var listOfPalindromeNumbers = new List<int>();

            foreach (var number in GenerateProductOfThreeDigitNumbers())
            {
                if (IsPalindrome(number))
                {
                    listOfPalindromeNumbers.Add(number);
                }
            }

            Console.WriteLine(listOfPalindromeNumbers.Max());
        }
    }
}

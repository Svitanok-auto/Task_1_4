using System;

namespace Practice4
{
    public class Program
    {
        public const int MAX_ATTEMPTS = 10;
        public static void Main(string[] args)
        {
            CheckIfStringIsAPalindromeInLoop();
            Console.ReadKey();
        }

        private static void CheckIfInputStringIsAPalindrome(char []array)
        {
            int i = 0;
            while ((array[i] == array[array.Length - i - 1]) && (i < (array.Length - 1) / 2) && (array.Length > 2) && (array.Length % 2 != 0))
            {
                i++;
            }
            if (i == (((array.Length - 1) / 2)) && (array.Length > 2) && (array.Length % 2 != 0))
            {
                Console.WriteLine("\nThe word is a Palindrome ");
            }
            else
            {
                Console.WriteLine("\nThe word is NOT a Palindrome ");
            }
        }

        private static void CheckIfStringIsAPalindromeInLoop()
        {
            int attempt = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                CheckIfInputStringIsAPalindrome(Validator.GetValidatedCharsArray());
            }
        }
    }
}

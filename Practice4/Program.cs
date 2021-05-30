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

        private static void CheckArrayLength(char []array)
        {
            if ((array.Length > 0) && (array.Length / 2 != 0))
            {
                PrintResult(CheckIfInputStringIsPalindrome(array, (array.Length - 1 / 2)));
            }
            else if (array.Length / 2 == 0)
            {
                PrintResult(CheckIfInputStringIsPalindrome(array, (array.Length / 2)));
            }
        }

        private static void PrintResult(bool isPalindrome)
        {
            if (isPalindrome)
            {
                Console.WriteLine("\nThe word is Palindrome");
            }
            else
            {
                Console.WriteLine("\nThe word is NOT Palindrome");
            }
        }

        private static bool CheckIfInputStringIsPalindrome(char[] array, int count)
        {
            int i = 0;
            {
                while ((i < count) && (array[i] == array[array.Length - i - 1]) )
                {
                    i++;
                }
                if ((i == count) && (array.Length > 2))
                {
                    return true;
                }
            }
            return false;
        }

        private static void CheckIfStringIsAPalindromeInLoop()
        {
            int attempt = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                CheckArrayLength(Validator.GetCharArray());
            }
        }
    }
}

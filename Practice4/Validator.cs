using System;

namespace Practice4
{
    public static class Validator
    {
        public const int MAX_ATTEMPTS = 10;

        public static char[] GetCharArray()
        {
            Console.WriteLine("\nPlease populate a word to check");
            int attempt = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                string inputString = Console.ReadLine();
                if (inputString.ToString() != string.Empty)
                {
                    try
                    {
                        char [] populatedCharactersArray= inputString.ToCharArray();
                        bool numberFlag = false;
                        foreach (char character in populatedCharactersArray)
                        {
                            if (char.IsDigit(character)||(!char.IsLetterOrDigit(character)))
                            {
                                numberFlag = true;
                                break;
                            }
                        }
                        if (numberFlag)
                        {
                            Console.WriteLine("\nA word or shouldn't contain numbers and special symbols; Try again ");
                            attempt++;
                            continue;
                        }
                        else if (!numberFlag)
                        {
                            return populatedCharactersArray;
                        }
                    }
                    catch (SystemException ex)
                    {
                        Console.WriteLine("\nIncorrect Input, error: " + ex.Message);
                        Console.WriteLine("\nTry again to populate correct string");
                        attempt++;
                    }
                }
                else
                {
                    Console.WriteLine("\nIncorrect Input: Empty string is not allowed");
                    attempt++;
                }
            }
        return default;
        }
    }
}

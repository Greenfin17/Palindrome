using System;

namespace Palindrome
{
    class Program
    {
        public delegate bool Validation(string input);

        public static bool GetInput()
        {
            Console.WriteLine($"Enter your palindrome"); 
            string input = Console.ReadLine();
            ConsoleKeyInfo escKey;
            bool invalid = true;
            bool returnVal = false;
            var palindromeObj = new PalindromeValidator();
            while (invalid)
            {
                if (palindromeObj.IsPalindrome(input))
                {
                    Console.WriteLine($"Your palindrome is valid. Thank you.\n");
                    invalid = false;
                    returnVal = true;
                }
                else
                {
                    Console.WriteLine($"Invalid palindrome. Please try again. Hit \"Esc\" to exit input");
                    escKey = Console.ReadKey(true);
                    if (escKey.Key == ConsoleKey.Escape)
                    {
                        invalid = false;
                    }
                    else
                    {
                        Console.Write(escKey.KeyChar);
                        input = Console.ReadLine();
                        // insert the first character if it was not the Esc key;
                        input = input.Insert(0, escKey.KeyChar.ToString());
                    }
                }
            }
            return returnVal;
        }
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                if (!GetInput())
                {
                    Console.WriteLine($"Valid palindrome not entered. Please try again later.");
                }
            }
        }
    }
}

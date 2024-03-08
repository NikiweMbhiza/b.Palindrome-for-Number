using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Palindrome_for_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a palindrome:");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input) || !long.TryParse(input, out long number))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            string reversedInput = ReverseString(input);

            if (input == reversedInput)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}

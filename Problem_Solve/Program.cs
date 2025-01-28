using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.First Problem

            int num1 = 20;
            int num2 = 30;
            int num3 = 40;
            int max_num = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"Maximum Number = {max_num}");


            // 2.Second Problem

            char letter = '?';
            if ((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z'))
            {
                Console.WriteLine($"This \"{letter}\" letter is an Alphabet.");
            }
            else
            {
                Console.WriteLine($"This \"{letter}\" letter is not an Alphabet.");
            }

            // 3. Third Problem
            int num = 15;
            if (num % 3 == 0 && num % 5 != 0)
            {
                Console.WriteLine($"The above {num} number is divisible Only by 3");
            }
            else if (num % 3 != 0 && num % 5 == 0)
            {
                Console.WriteLine($"The above {num} number is divisible Only by 5");
            }
            else if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine($"The above {num} number is divisible Only by 5 && 3");
            }
            else
            {
                Console.WriteLine($"The above {num} number is not divisible Neither 5 nor 3.");
            }

        }
    }
}